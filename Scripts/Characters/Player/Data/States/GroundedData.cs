using System;
using UnityEngine;

namespace OfflineMethod
{
    [Serializable]
    public class GroundedData
    {
        [field: SerializeField][field: Range(0f, 25f)] public float BaseSpeed { get; private set; } = 5f;
        [field: SerializeField] public RotationData BaseRotationData { get; private set; }
        [field: SerializeField] public WalkData WalkData { get; private set; }
        [field: SerializeField] public RunData RunData { get; private set; }

    }
}
