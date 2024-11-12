using UnityEngine;

namespace OfflineMethod
{
    [CreateAssetMenu(fileName = "Player", menuName = "Custom/Characters/Player")]
    public class PlayerSO : ScriptableObject
    {
        [field: SerializeField] public GroundedData GroundedData { get; private set; }
    }
}
