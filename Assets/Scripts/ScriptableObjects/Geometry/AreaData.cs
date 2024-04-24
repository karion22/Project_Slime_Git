// Copyright
using UnityEngine;

namespace Project.Slime
{
    [CreateAssetMenu(menuName = "ScriptableObject/Geometry/AreaData", order = 2)]
    public class AreaData : ScriptableObject
    {
        public TileData[] TilePresets;
        [Range(0, 100)] public int[] TileRatios;
        public int Width;
        public int Height;

        public ObjectData[] ObjectPresets;
    }
}
