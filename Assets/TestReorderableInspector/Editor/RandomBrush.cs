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
		[Reorderable]
		public TileBase[] randomTiles;
		public TileOrientation orientation;
	}
}
