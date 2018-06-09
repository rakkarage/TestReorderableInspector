using System;
using System.Collections.Generic;
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
	public List<T> array;
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

		// var test = new ReorderableArrayInspector();
		// if (test != null)
		// 	Debug.Log(test);
		// test.DrawDefaultInspector();

		// Debug.Log(property);
		// Debug.Log(property.serializedObject);
		// var list = property.FindPropertyRelative("array");
		// Debug.Log(list);
		// var r = new ReorderableList(property.serializedObject, list, true, true, true, true);
		// var x = ReorderableList.defaultBehaviours.draggingHandle;
		// ;
		// r.drawElementCallback =
		// 	(Rect rect, int index, bool isActive, bool isFocused) =>
		// 	{

		// 		EditorGUI.PropertyField(rect, list.GetArrayElementAtIndex(index));
		// 	};
		// r.DoList(position);



		// if (EditorGUI.EndChangeCheck())
		// {
		// 	property.serializedObject.ApplyModifiedProperties();
		// }
		EditorGUI.EndProperty();
	}
}
#endif
