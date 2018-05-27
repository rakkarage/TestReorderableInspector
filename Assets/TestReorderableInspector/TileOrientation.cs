using System;
using UnityEditor;
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