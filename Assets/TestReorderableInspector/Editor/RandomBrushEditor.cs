using System;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	// if i remove this attribute it works in inspector and paint inspector
	// and does not use this class at all
	// but i need to use this attribute to link this other non gui related (preview etc) code to the brush
	// so i use DrawDefaultInspector
	// it works for my CustomPropertyDrawer for enum flags but does not work for ReorderableInspector?
	[CustomEditor(typeof(RandomBrush))]
	public class RandomBrushEditor : GridBrushEditor
	{
		public override void PaintPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
			Debug.Log("PaintPreview!");
		}
		private void GUI()
		{
			DrawDefaultInspector();
		}
		public override void OnPaintInspectorGUI() => GUI();
		public override void OnInspectorGUI() => GUI();
	}
}
