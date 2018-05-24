using System;
using SubjectNerd.Utilities;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	[CreateAssetMenu]
	[CustomGridBrush(false, true, false, "Random Brush")]
	[Serializable]
	public class RandomBrush : GridBrush
	{
		// [Reorderable]
		public TileBase[] randomTiles;
	}
	// TODO: this not work???
// #if UNITY_EDITOR
// 	[CustomEditor(typeof(RandomBrush))]
// 	public class RandomBrushEditor : GridBrushEditor
// 	{
// 	}
// #endif
}
