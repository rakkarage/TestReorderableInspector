using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using SubjectNerd.Utilities;
#if UNITY_EDITOR
using UnityEditor;
#endif
[CreateAssetMenu]
[Serializable]
public class TestB : ScriptableObject
{
	public int[] Test;
	public TileOrientation Orientation;
}
#if UNITY_EDITOR
[CustomEditor(typeof(TestB))]
public class TestBEditor : Editor
{
	ReorderableArrayInspector editor;
	public override void OnInspectorGUI()
	{
		if (!editor)
			editor = Editor.CreateEditor(target, typeof(ReorderableArrayInspector)) as ReorderableArrayInspector;
		editor.OnInspectorGUI();
	}
}
#endif
