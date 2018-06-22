using UnityEditor;
namespace UnityEngine.Tilemaps
{
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
}
