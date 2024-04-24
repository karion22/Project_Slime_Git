using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    public class GameMgr : Singleton<GameMgr>
    {
        [SerializeField] private MapController m_MapController = null;
        [SerializeField] private SpawnController m_SpawnController = null;

        public override void Start()
        {
            m_MapController.Build();
            m_SpawnController.Spawn();
        }
    }
}
