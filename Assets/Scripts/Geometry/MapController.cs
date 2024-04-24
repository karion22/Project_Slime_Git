// Map은 Grid를 관리하고, 
// Grid는 Tile을 관리한다.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    public class MapController : MonoBehaviour
    {
        [SerializeField] private LevelData m_LevelData;
        private Vector3 m_CenterPosition;

        public Vector2 MapSize = Vector2.zero;

        public void Build()
        {
            if(m_LevelData != null)
            {
                // TODO : 중심 좌표는 재계산이 필요하다,.
                m_CenterPosition = new Vector3(64f, 0, 64f);
                MapSize = new Vector2(128f, 128f);

                for (int h = 0; h < m_LevelData.Height; h++)
                {
                    for(int w = 0; w < m_LevelData.Width; w++)
                    {
                        AreaData area = SelectArea(ref m_LevelData);
                        BuildArea(ref area, w, h);
                    }
                }
            }
        }

        private void BuildArea(ref AreaData areaData, int lw, int lh)
        {
            if (areaData == null) return;

            for (int h = 0; h < areaData.Height; h++)
            {
                for (int w = 0; w < areaData.Width; w++)
                {
                    var tile = SelectTile(ref areaData);

                    Vector3 newPos = new Vector3((32f * lw) - m_CenterPosition.x + w, -0.5f, (32f * lh) - m_CenterPosition.z + h);
                    Instantiate(tile.TilePrefab, newPos, Quaternion.identity, transform);
                }
            }
        }

        private AreaData SelectArea(ref LevelData levelData)
        {
            if (levelData == null)
                Debug.LogWarning("Warning!!! Level data is empty");
            else
            {
                int rndValue = Random.Range(0, 100);
                int sumValue = 0;

                for (int i = 0, end = levelData.AreaRatios.Length; i < end; i++)
                {
                    sumValue += levelData.AreaRatios[i];

                    if (rndValue < sumValue) return levelData.AreaPresets[i];
                }

                if (levelData.AreaPresets.Length > 0)
                    return levelData.AreaPresets[0];
            }
            return null;
        }

        private TileData SelectTile(ref AreaData areaData)
        {
            if(areaData == null)
            {
                Debug.LogWarning("Warning!!! AreaData is empty");
            }
            else
            {
                int rndValue = Random.Range(0, 100);
                int sumValue = 0;

                for (int i = 0, end = areaData.TileRatios.Length; i < end; i++)
                {
                    sumValue += areaData.TileRatios[i];

                    if (rndValue < sumValue) return areaData.TilePresets[i];
                }

                if(areaData.TilePresets.Length > 0)
                    return areaData.TilePresets[0];
            }

            return null;
        }
    }
}
