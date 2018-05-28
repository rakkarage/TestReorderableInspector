using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using SubjectNerd.Utilities;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal;
#endif
[CreateAssetMenu]
[Serializable]
public class TestB : ScriptableObject
{
	// [Reorderable]
	public ReorderableArrayInt Test;
	public TileOrientation Orientation;
}
public class ReorderableArray<T>
{
	public T[] array;
}
[Serializable]
public class ReorderableArrayInt : ReorderableArray<int>
{
}
#if UNITY_EDITOR
// [CustomEditor(typeof(TestB))]
// public class TestBEditor : Editor
// {
// 	public void OnEnable()
// 	{
// 		Debug.Log("OnEnable");
// 	}
// 	public override void OnInspectorGUI()
// 	{
// 		DrawDefaultInspector();
// 	}
// }
[CustomPropertyDrawer(typeof(ReorderableArrayInt))]
public class IntArrayDrawer : PropertyDrawer
{
	private bool _initialized = false;
	private void Initialize(SerializedProperty property)
	{
		_initialized = true;
	}
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		// if (!_initialized)
		// 	Initialize(property);
		label = EditorGUI.BeginProperty(position, label, property);

		// // var ra = new ReorderableArrayInspector();
		// // ra.DrawPropertiesAll();//.DrawDefaultInspector();
		EditorGUI.HelpBox(position, "FUCK OFF", MessageType.Info);

		// if (EditorGUI.EndChangeCheck())
		// {
		// 	property.serializedObject.ApplyModifiedProperties();
		// }
		EditorGUI.EndProperty();
	}
}
#endif
