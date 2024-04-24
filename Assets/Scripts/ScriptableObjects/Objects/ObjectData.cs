using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Project.Slime
{
    [CreateAssetMenu(menuName = "ScriptableObject/ObjectData", order = 1)]
    public class ObjectData : ScriptableObject
    {
        // 아이템 타입
        public eObjectItemType ItemType;

        // 아이템 프리팹
        public GameObject ItemPrefab;

        // 섭취를 위해 필요한 파워
        public int RequireLevel;

        // 잘못 섭취 시 데미지
        public int Damage;

        // 획득 시 경험치
        public int Exp;

        // 자동 제거 시간
        public float Timer;

        // 획득 연출
        public GameObject AcquireEffect;
    }
}
