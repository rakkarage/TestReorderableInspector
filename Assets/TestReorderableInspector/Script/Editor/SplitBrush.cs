using UnityEditor;
namespace UnityEngine.Tilemaps
{
	[CreateAssetMenu]
	[CustomGridBrush(false, true, false, "Split Brush")]
	public class SplitBrush : GridBrush
	{
		public TileBase Back;
		public string BackMap = "Back";
		public Vector2Int BackOffset;
		public TileBase Fore;
		public string ForeMap = "Fore";
		public Vector2Int ForeOffset;
		public override void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
			var maps = brushTarget?.transform.parent.GetComponentsInChildren<Tilemap>();
			for (var i = 0; i < maps.Length; i++)
			{
				var map = maps[i];
				var name = map.name;
				if (name == BackMap)
				{
					var p = new Vector3Int(position.x + BackOffset.x, position.y + BackOffset.y, position.z);
					map.SetTile(p, Back);
					map.SetTransformMatrix(p, Matrix4x4.identity);
				}
				else if (name == ForeMap)
				{
					var p = new Vector3Int(position.x + ForeOffset.x, position.y + ForeOffset.y, position.z);
					map.SetTile(p, Fore);
					map.SetTransformMatrix(p, Matrix4x4.identity);
				}
			}
		}
	}
}
