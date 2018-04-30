using SubjectNerd.Utilities;
using UnityEngine;
using UnityEngine.Tilemaps;
namespace UnityEditor
{
	[CreateAssetMenu]
	[CustomGridBrush(false, true, false, "Random Brush")]
	public class RandomBrush : GridBrush
	{
		[Reorderable]
		public TileBase[] randomTiles;
	}
#if UNITY_EDITOR
	[CustomEditor(typeof(RandomBrush))]
	public class RandomBrushEditor : GridBrushEditor
	{
	}
#endif
}
