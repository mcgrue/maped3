using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace winmaped2
{
	static class JsonExtensions
	{
		public static JArray AsArray(this JToken o) { return (JArray)o; }
	}
	partial class InputOutput
	{
		static Map ReadMapJson(FileInfo fi)
		{
			Map map = new Map();

			var root = JObject.Parse(File.ReadAllText(fi.FullName));

			int version = (int)root["version"];

			//basic map properties
			map.MusicFileName = (string)root["MusicFileName"];
			map.FormalName = (string)root["FormalName"];
			map.AutoExecEvent = (string)root["AutoExecEvent"];
			map.PlayerStartX = (int)root["PlayerStartX"];
			map.PlayerStartY = (int)root["PlayerStartY"];

			//some basic collections
			map.Notes = JsonConvert.DeserializeObject<List<Map.Note>>((string)root["Notes"]);
			map.Zones = JsonConvert.DeserializeObject<List<MapZone>>((string)root["Zones"]);

			//entities are maybe tricky... but not yet!
			map.Entities = JsonConvert.DeserializeObject<List<MapEntity>>((string)root["Entities"]);

			//regular map layers
			foreach (var jml in root["Layers"])
			{
				var ml = JsonConvert.DeserializeObject<MapLayer>((string)jml);
				if (ml.type == LayerType.Special_Retrace)
				{
					ml = JsonConvert.DeserializeObject<MapLayerSpecial>((string)jml);
					ml.parentmap = map;
				}
				map.Layers.Add(ml);
			}

			//other map data layers
			map.ObsLayer = JsonConvert.DeserializeObject<MapLayer>((string)root["ObsLayer"]); 
			map.ObsLayer.parentmap = map;
			map.ZoneLayer = JsonConvert.DeserializeObject<MapLayer>((string)root["ZoneLayer"]); 
			map.ZoneLayer.parentmap = map;
			map.EntLayer = JsonConvert.DeserializeObject<MapLayer>((string)root["EntLayer"]); 
			map.EntLayer.parentmap = map;

			map.RenderString = "1,2";

			return map;
		}

		static void WriteMapJson(FileInfo fi, Map map)
		{
			var root = new JObject();
			
			root["version"] = 1;

			//basic map properties
			root["MusicFileName"] = map.MusicFileName;
			root["FormalName"] = map.FormalName;
			root["AutoExecEvent"] = map.AutoExecEvent;
			root["PlayerStartX"] = map.PlayerStartX;
			root["PlayerStartY"] = map.PlayerStartY;

			//shitty properties
			root["VSPName"] = Helper.GetRelativePath(map.FileOnDisk.Directory.FullName, map.vsp.FileOnDisk.FullName);

			//some basic collections
			root["Notes"] = JsonConvert.SerializeObject(map.Notes);
			root["Zones"] = JsonConvert.SerializeObject(map.Zones);
			
			//entities are maybe tricky... but not yet!
			root["Entities"] = JsonConvert.SerializeObject(map.Entities);

			root["Layers"] = new JArray();
			Func<MapLayer,string> serializeLayer = (MapLayer layer) =>
			{
				return JsonConvert.SerializeObject(layer);
			};

			root["ObsLayer"] = serializeLayer(map.ObsLayer);
			root["ZoneLayer"] = serializeLayer(map.ZoneLayer);
			root["EntLayer"] = serializeLayer(map.EntLayer);
			foreach (var ml in map.Layers)
			{
				root["Layers"].AsArray().Add(serializeLayer(ml));
			}

			File.WriteAllText((fi.FullName + ".json.txt"), root.ToString());
		}
	}
}