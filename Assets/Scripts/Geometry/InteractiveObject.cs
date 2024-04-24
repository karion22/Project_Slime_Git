using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    public class InteractiveObject : MonoBehaviour, IAcquirable
    {
        public void Acquired(ObjectData inData) 
        {
            if (inData == null) return;
            else
            {
                Instantiate(inData.AcquireEffect, transform);
            }
        }
    }
}
