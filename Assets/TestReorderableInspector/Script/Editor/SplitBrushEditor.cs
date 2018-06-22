using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	[CustomEditor(typeof(SplitBrush))]
	public class SplitBrushEditor : GridBrushEditor
	{
		private SplitBrush Brush => target as SplitBrush;
		public override void PaintPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
			var brush = Brush;
			var maps = brushTarget?.transform.parent.GetComponentsInChildren<Tilemap>();
			for (var i = 0; i < maps.Length; i++)
			{
				var map = maps[i];
				var name = map.name;
				if (name == brush.BackMap)
				{
					var p = new Vector3Int(position.x + brush.BackOffset.x, position.y + brush.BackOffset.y, position.z);
					map.SetEditorPreviewTile(p, brush.Back);
					map.SetEditorPreviewTransformMatrix(p, Matrix4x4.identity);
				}
				else if (name == brush.ForeMap)
				{
					var p = new Vector3Int(position.x + brush.ForeOffset.x, position.y + brush.ForeOffset.y, position.z);
					map.SetEditorPreviewTile(p, brush.Fore);
					map.SetEditorPreviewTransformMatrix(p, Matrix4x4.identity);
				}
			}
		}
		public override void BoxFillPreview(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}
		public override void FloodFillPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}
		public override void ClearPreview()
		{
		}
		public override GameObject[] validTargets
		{
			get
			{
				var brush = Brush;
				var list = from map in GameObject.FindObjectsOfType<Tilemap>()
						   where (map.gameObject.name == brush.BackMap) || (map.gameObject.name == brush.ForeMap)
						   select map.gameObject;
				return list.ToArray();
			}
		}
	}
}
