using Homebrew;
using System;
using UnityEngine;
namespace UnityEngine.Tilemaps
{
	[CreateAssetMenu]
	[Serializable]
	public class TestB : ScriptableObject
	{
		[Foldout("test0")]
		public int test0;

		[Foldout("A")]
		public int[] test;
		[Foldout("AA")]
		public TileOrientation orientation;
	}
}
