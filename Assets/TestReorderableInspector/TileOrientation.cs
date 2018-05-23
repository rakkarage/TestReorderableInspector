using System;
using System.Linq;
using UnityEditor;
using UnityEngine;
namespace UnityEngine.Tilemaps
{
	[Flags]
	public enum TileOrientation
	{
		None = 0,
		FlipX = 1,
		FlipY = (1 << 1),
		Rot90 = (1 << 2),
	}
	[Serializable]
	public struct RandomTileGenerator
	{
		public TileOrientation orientation;
		public bool RandomBool => Random.value > .5f;
		public bool FlipX => (orientation & TileOrientation.FlipX) == TileOrientation.FlipX ? RandomBool : false;
		public bool FlipY => (orientation & TileOrientation.FlipY) == TileOrientation.FlipY ? RandomBool : false;
		public bool Rot90 => (orientation & TileOrientation.Rot90) == TileOrientation.Rot90 ? RandomBool : false;
		public static Quaternion RotateClockwise = Quaternion.Euler(0, 0, -90f);
		public static Quaternion RotateCounter = Quaternion.Euler(0, 0, 90f);
		public Matrix4x4 NextMatrix => Matrix4x4.TRS(Vector3.zero,
			Rot90 ? RotateClockwise : Quaternion.identity, new Vector3(FlipX ? -1f : 1f, FlipY ? -1f : 1f, 1f));
		public TileBase[] RandomTiles;
		public int[] Probabilities;
		public TileBase NextTile
		{
			get
			{
				if (RandomTiles?.Length > 0 && RandomTiles?.Length == Probabilities?.Length)
				{
					var total = 0f;
					var roll = Random.Range(0, Probabilities.Sum());
					for (var i = 0; i < Probabilities.Length; i++)
					{
						total += Probabilities[i];
						if (roll < total)
							return RandomTiles[i];
					}
				}
				return RandomTiles[Random.Range(0, RandomTiles.Length)];
			}
		}
	}
#if UNITY_EDITOR
	[CustomPropertyDrawer(typeof(TileOrientation))]
	public class TileOrientationDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
		{
			label = EditorGUI.BeginProperty(position, label, property);
			property.intValue = (int)(TileOrientation)EditorGUI.EnumFlagsField(position, label, (TileOrientation)property.intValue);
			EditorGUI.EndProperty();
		}
	}
#endif
}
