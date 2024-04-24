using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    [CreateAssetMenu(menuName = "ScriptableObject/Geometry/TileData", order = 3)]
    public class TileData : ScriptableObject
    {
        public GameObject TilePrefab;
        public int TileSize;
    }
}
