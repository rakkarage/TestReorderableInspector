using System;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	// [CustomEditor(typeof(RandomBrush))]
	public class RandomBrushEditor : GridBrushEditor
	{
		public override void PaintPreview(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
			Debug.Log("TEST!");
		}
	}
}
