﻿using System;
using SubjectNerd.Utilities;
using UnityEngine;
using UnityEngine.Tilemaps;
[CreateAssetMenu]
// [CustomGridBrush(false, true, false, "Random Brush")]
[Serializable]
public class TestB : ScriptableObject
{

	public int[] test;
}
// #if UNITY_EDITOR
// 	[CustomEditor(typeof(RandomBrush))]
// 	public class RandomBrushEditor : GridBrushEditor
// 	{
// 	}
// #endif
