using System;
using UnityEngine;
namespace UnityEngine.Tilemaps
{
	[CreateAssetMenu]
	[Serializable]
	public class TestB : ScriptableObject
	{
		[Foldout("A")]
		public int[] test;
		public TileOrientation orientation;
	}
}
