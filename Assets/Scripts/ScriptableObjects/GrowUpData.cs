using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    [System.Serializable]
    public struct GrowUpValue
    {
        public GameObject GamePrefab;
        public int Level;
    }

    [CreateAssetMenu(fileName = "GrowUp", menuName = "ScriptableObject/GrowUp", order = 1)]
    public class GrowUpData : ScriptableObject
    {
        public GrowUpValue[] Values;
    }
}
