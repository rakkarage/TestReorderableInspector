using System;
namespace UnityEngine.Tilemaps
{
	[CreateAssetMenu]
	[Serializable]
	public class RandomTile : TileBase
	{
		public TileBase[] randomTiles;
		public TileOrientation orientation;
	}
}
