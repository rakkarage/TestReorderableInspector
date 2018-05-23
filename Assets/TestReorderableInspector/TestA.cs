using System;
using UnityEngine;
namespace UnityEngine.Tilemaps
{
	[CreateAssetMenu]
	[Serializable]
	public class TestA : ScriptableObject
	{
		public int[] test;
		public TileOrientation orientation;
	}
}
