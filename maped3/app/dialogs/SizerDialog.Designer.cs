namespace winmaped2
{
	partial class SizerDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtLeft = new System.Windows.Forms.TextBox();
			this.txtAbove = new System.Windows.Forms.TextBox();
			this.txtRight = new System.Windows.Forms.TextBox();
			this.txtBelow = new System.Windows.Forms.TextBox();
			this.txtOldX = new System.Windows.Forms.TextBox();
			this.txtOldY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNewY = new System.Windows.Forms.TextBox();
			this.txtNewX = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnSaveAs = new System.Windows.Forms.Button();
			this.txtNWx = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNWy = new System.Windows.Forms.TextBox();
			this.txtSEy = new System.Windows.Forms.TextBox();
			this.txtSEx = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtLeft
			// 
			this.txtLeft.Location = new System.Drawing.Point(76, 73);
			this.txtLeft.Name = "txtLeft";
			this.txtLeft.Size = new System.Drawing.Size(42, 20);
			this.txtLeft.TabIndex = 1;
			this.txtLeft.Text = "0";
			this.txtLeft.TextChanged += new System.EventHandler(this.txtLeft_TextChanged);
			// 
			// txtAbove
			// 
			this.txtAbove.Location = new System.Drawing.Point(117, 47);
			this.txtAbove.Name = "txtAbove";
			this.txtAbove.Size = new System.Drawing.Size(42, 20);
			this.txtAbove.TabIndex = 2;
			this.txtAbove.Text = "0";
			this.txtAbove.TextChanged += new System.EventHandler(this.txtAbove_TextChanged);
			// 
			// txtRight
			// 
			this.txtRight.Location = new System.Drawing.Point(161, 73);
			this.txtRight.Name = "txtRight";
			this.txtRight.Size = new System.Drawing.Size(42, 20);
			this.txtRight.TabIndex = 3;
			this.txtRight.Text = "0";
			this.txtRight.TextChanged += new System.EventHandler(this.txtRight_TextChanged);
			// 
			// txtBelow
			// 
			this.txtBelow.Location = new System.Drawing.Point(117, 99);
			this.txtBelow.Name = "txtBelow";
			this.txtBelow.Size = new System.Drawing.Size(42, 20);
			this.txtBelow.TabIndex = 4;
			this.txtBelow.Text = "0";
			this.txtBelow.TextChanged += new System.EventHandler(this.txtBelow_TextChanged);
			// 
			// txtOldX
			// 
			this.txtOldX.Location = new System.Drawing.Point(82, 6);
			this.txtOldX.Name = "txtOldX";
			this.txtOldX.ReadOnly = true;
			this.txtOldX.Size = new System.Drawing.Size(42, 20);
			this.txtOldX.TabIndex = 5;
			// 
			// txtOldY
			// 
			this.txtOldY.Location = new System.Drawing.Point(148, 6);
			this.txtOldY.Name = "txtOldY";
			this.txtOldY.ReadOnly = true;
			this.txtOldY.Size = new System.Drawing.Size(42, 20);
			this.txtOldY.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(130, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "x";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Current Size";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "New Size";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(130, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "x";
			// 
			// txtNewY
			// 
			this.txtNewY.Location = new System.Drawing.Point(148, 141);
			this.txtNewY.Name = "txtNewY";
			this.txtNewY.ReadOnly = true;
			this.txtNewY.Size = new System.Drawing.Size(42, 20);
			this.txtNewY.TabIndex = 10;
			// 
			// txtNewX
			// 
			this.txtNewX.Location = new System.Drawing.Point(82, 141);
			this.txtNewX.Name = "txtNewX";
			this.txtNewX.ReadOnly = true;
			this.txtNewX.Size = new System.Drawing.Size(42, 20);
			this.txtNewX.TabIndex = 9;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(298, 238);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(217, 238);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 14;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnSaveAs
			// 
			this.btnSaveAs.Location = new System.Drawing.Point(12, 238);
			this.btnSaveAs.Name = "btnSaveAs";
			this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
			this.btnSaveAs.TabIndex = 15;
			this.btnSaveAs.Text = "Save As";
			this.btnSaveAs.UseVisualStyleBackColor = true;
			this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
			// 
			// txtNWx
			// 
			this.txtNWx.Location = new System.Drawing.Point(46, 41);
			this.txtNWx.Name = "txtNWx";
			this.txtNWx.Size = new System.Drawing.Size(42, 20);
			this.txtNWx.TabIndex = 16;
			this.txtNWx.TextChanged += new System.EventHandler(this.txtNWx_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtSEy);
			this.groupBox1.Controls.Add(this.txtSEx);
			this.groupBox1.Controls.Add(this.txtNWy);
			this.groupBox1.Controls.Add(this.txtNWx);
			this.groupBox1.Location = new System.Drawing.Point(217, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(156, 100);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Crop to NW -> SE bounds";
			// 
			// txtNWy
			// 
			this.txtNWy.Location = new System.Drawing.Point(94, 41);
			this.txtNWy.Name = "txtNWy";
			this.txtNWy.Size = new System.Drawing.Size(42, 20);
			this.txtNWy.TabIndex = 17;
			this.txtNWy.TextChanged += new System.EventHandler(this.txtNWy_TextChanged);
			// 
			// txtSEy
			// 
			this.txtSEy.Location = new System.Drawing.Point(94, 67);
			this.txtSEy.Name = "txtSEy";
			this.txtSEy.Size = new System.Drawing.Size(42, 20);
			this.txtSEy.TabIndex = 19;
			this.txtSEy.TextChanged += new System.EventHandler(this.txtSEy_TextChanged);
			// 
			// txtSEx
			// 
			this.txtSEx.Location = new System.Drawing.Point(46, 67);
			this.txtSEx.Name = "txtSEx";
			this.txtSEx.Size = new System.Drawing.Size(42, 20);
			this.txtSEx.TabIndex = 18;
			this.txtSEx.TextChanged += new System.EventHandler(this.txtSEx_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "NW";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(21, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "SE";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(43, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "(inclusive)";
			// 
			// SizerDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 273);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSaveAs);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtNewY);
			this.Controls.Add(this.txtNewX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtOldY);
			this.Controls.Add(this.txtOldX);
			this.Controls.Add(this.txtBelow);
			this.Controls.Add(this.txtRight);
			this.Controls.Add(this.txtAbove);
			this.Controls.Add(this.txtLeft);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SizerDialog";
			this.Text = "SizerDialog";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLeft;
		private System.Windows.Forms.TextBox txtAbove;
		private System.Windows.Forms.TextBox txtRight;
		private System.Windows.Forms.TextBox txtBelow;
		private System.Windows.Forms.TextBox txtOldX;
		private System.Windows.Forms.TextBox txtOldY;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNewY;
		private System.Windows.Forms.TextBox txtNewX;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnSaveAs;
		private System.Windows.Forms.TextBox txtNWx;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSEy;
		private System.Windows.Forms.TextBox txtSEx;
		private System.Windows.Forms.TextBox txtNWy;
		private System.Windows.Forms.Label label7;

	}
}