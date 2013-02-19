using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winmaped2
{
	public partial class SizerDialog : Form
	{
		int currWidth, currHeight;
		int newWidth, newHeight;

		int above, below, left, right;

		public SizerDialog()
		{
			InitializeComponent();

			currWidth = Global.ActiveMap.Layers.Max(x => x.Width);
			currHeight = Global.ActiveMap.Layers.Max(x => x.Height);

			recalc();
		}

		void recalc()
		{
			newWidth = currWidth + left + right;
			newHeight = currHeight + above + below;
			txtNewX.Text = newWidth.ToString();
			txtNewY.Text = newHeight.ToString();
			txtOldX.Text = currWidth.ToString();
			txtOldY.Text = currHeight.ToString();
		}

		private void txtAbove_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtAbove.Text, out above);
			recalc();
		}

		private void txtRight_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtRight.Text, out right);
			recalc();
		}

		private void txtBelow_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtBelow.Text, out below);
			recalc();
		}

		private void txtLeft_TextChanged(object sender, EventArgs e)
		{
			int.TryParse(txtLeft.Text, out left);
			recalc();
		}

		void corners()
		{
			int nwx,nwy,sex,sey;
			int.TryParse(txtNWx.Text, out nwx);
			int.TryParse(txtNWy.Text, out nwy);
			int.TryParse(txtSEx.Text, out sex);
			int.TryParse(txtSEy.Text, out sey);
			left = -nwx;
			above = -nwy;
			//int mywidth = sex - nwx + 1;
			//int myheight = sey - nwy + 1;
			right = -(currWidth - sex - 1);
			below = -(currHeight - sey - 1);

			txtAbove.Text = above.ToString();
			txtBelow.Text = below.ToString();
			txtLeft.Text = left.ToString();
			txtRight.Text = right.ToString();
		}

		private void txtNWx_TextChanged(object sender, EventArgs e)
		{
			corners();
			recalc();
		}

		private void txtNWy_TextChanged(object sender, EventArgs e)
		{
			corners();
			recalc();
		}

		private void txtSEx_TextChanged(object sender, EventArgs e)
		{
			corners();
			recalc();
		}

		private void txtSEy_TextChanged(object sender, EventArgs e)
		{
			corners();
			recalc();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			resize(Global.ActiveMap);
			Global.mainWindow.Refresh();
			Global.MiniMap.Refresh();
		}

		void resize(Map map)
		{
			//fixup each layer
			foreach (var layer in map.Layers)
			{
				var od = layer.Data;
				if (od == null) continue;
				var ow = layer.Width;
				var oh = layer.Height;
				var nw = newWidth;
				var nh = newHeight;
				
				var nd = new short[nw * nh];
				layer.Data = nd;
				layer._Width = nw;
				layer._Height = nh;

				int dx = 0, dy = 0;
				int sx, sy = -above;

				for (int y = 0; y < nh; y++, sy++, dy++)
				{
					sx = -left;
					dx = 0;
					for (int x = 0; x < nw; x++, sx++, dx++)
					{
						if (sx < 0) continue;
						if (sy < 0) continue;
						short tile = 0;
						if (sx < ow && sy < oh)
							tile = od[sy * ow + sx]; 
						nd[dy * nw + dx] = tile;
					}
				}
			}

			//fixup each note
			foreach (var note in map.Notes)
			{
				note.x += left * Global.TILE_SIZE;
				note.y += above * Global.TILE_SIZE;
			}

			//fixup each entity
			foreach (var ent in map.Entities)
			{
				ent.TileX += left;
				ent.TileY += above;
			}
		}

		private void btnSaveAs_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			sfd.Filter = "Map Files (*.map)|*.map";
			sfd.FilterIndex = 0;
			sfd.InitialDirectory = Global.ActiveMap.FileOnDisk.DirectoryName;
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				var fi = new System.IO.FileInfo(sfd.FileName);
				InputOutput.WriteMap(fi, Global.ActiveMap);

				var tempMap = InputOutput.ReadMap(fi.FullName);
				resize(tempMap);
				InputOutput.WriteMap(fi, tempMap);
			}
		}
	}
}
