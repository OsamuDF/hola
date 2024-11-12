using System;
using UnityEngine;

namespace OfflineMethod
{
    [Serializable]
    public class RunData
    {
        [field: SerializeField] [field: Range(1f, 2f)] public float SpeedModifier { get; private set; } = 1f;
    }
}
