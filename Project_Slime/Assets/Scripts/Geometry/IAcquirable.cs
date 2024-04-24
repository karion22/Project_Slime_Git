using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Slime
{
    public interface IAcquirable
    {
        public abstract void Acquired(ObjectData inData);
    }
}
