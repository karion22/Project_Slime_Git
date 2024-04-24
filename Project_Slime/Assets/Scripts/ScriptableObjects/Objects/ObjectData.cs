using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Project.Slime
{
    [CreateAssetMenu(menuName = "ScriptableObject/ObjectData", order = 1)]
    public class ObjectData : ScriptableObject
    {
        // ������ Ÿ��
        public eObjectItemType ItemType;

        // ������ ������
        public GameObject ItemPrefab;

        // ���븦 ���� �ʿ��� �Ŀ�
        public int RequireLevel;

        // �߸� ���� �� ������
        public int Damage;

        // ȹ�� �� ����ġ
        public int Exp;

        // �ڵ� ���� �ð�
        public float Timer;

        // ȹ�� ����
        public GameObject AcquireEffect;
    }
}
