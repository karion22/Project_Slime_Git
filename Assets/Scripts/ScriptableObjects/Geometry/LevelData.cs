using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    [CreateAssetMenu(menuName = "ScriptableObject/Geometry/LevelData", order = 1)]
    public class LevelData : ScriptableObject
    {
        public AreaData[] AreaPresets;
        [Range(0, 100)] public int[] AreaRatios;
        public int Width;
        public int Height;
    }
}
