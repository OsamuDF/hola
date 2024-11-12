using System;
using UnityEngine;

namespace OfflineMethod
{
    [Serializable]
    public class RotationData
    {
        [field: SerializeField] public Vector3 TargetRotationReachTime { get; private set; }
    }
}
