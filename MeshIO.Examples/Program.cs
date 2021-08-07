﻿using MeshIO.Elements;
using MeshIO.FBX;
using MeshIO.GLTF;
using System;
using System.IO;

namespace MeshIO.Examples
{
	class Program
	{
		static void Main(string[] args)
		{
			//FbxExample();
			GltfExample();

			Console.WriteLine("Program finished");
		}

		static void FbxExample()
		{
			string pathI = @".\..\..\..\..\file_samples\fbx\objects_ascii_2014-2015.fbx";
			string pathO = @".\..\..\..\..\file_samples\fbx\objects_ascii_2014-2015_out.fbx";

			Scene scene = FbxReader.Read(pathI, ErrorLevel.Checked);
			FbxWriter.WriteAscii(pathO, scene);
		}

		static void GltfExample()
		{
			string pathI = @".\..\..\..\..\file_samples\gltf\2CylinderEngine.glb";
			string pathO = @".\..\..\..\..\file_samples\gltf\2CylinderEngine_out.fbx";

			using (GltfReader reader = new GltfReader(pathI))
			{
				Scene scene = reader.Read();
				FbxWriter.WriteAscii(pathO, scene);
			}
		}
	}
}