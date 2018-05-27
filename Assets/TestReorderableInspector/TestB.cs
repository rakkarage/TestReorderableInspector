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
	[Reorderable]
	public int[] Test;
	public TileOrientation Orientation;
}
#if UNITY_EDITOR
[CustomEditor(typeof(TestB))]
public class TestBEditor : Editor
{
	public void OnEnable()
	{
		Debug.Log("OnEnable");
	}
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
	}
}
#endif
