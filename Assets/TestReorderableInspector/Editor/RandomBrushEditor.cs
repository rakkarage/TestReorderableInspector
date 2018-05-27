using System;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	// https://github.com/SubjectNerd-Unity/ReorderableInspector
	// if i remove this attribute it works in inspector and paint inspector
	// because does not use this class at all
	// but i need to use this attribute to link this other non gui related (preview etc) code to the brush
	// so i use DrawDefaultInspector
	// it works for my CustomPropertyDrawer for enum flags but does not work for ReorderableInspector?
	// - [Reorderable] attribute does not work
	// - cannot derive from ReorderableArrayInspector because i need to derive from GridBrushEditor
	// is there any way to make it show ReorderableInspector for RandomTile AND RandomBrush?
	// thanks
	// https://github.com/rakkarage/TestReorderableInspector
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
