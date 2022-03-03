using UnityEngine;

namespace _Root.Scripts.Services.Ads.Settings
{
    [CreateAssetMenu(fileName = nameof(UnityAdSettings), menuName = "Settings/Ads/" + nameof(UnityAdSettings))]
    internal class UnityAdSettings : ScriptableObject
    {
        [Header("Game ID")]
        [SerializeField] private string _androidGameId;
        [SerializeField] private string _iOsGameId;

        [field: Header("Players")]
        [field: SerializeField] public AdPlayerSettings Interstitial { get; private set; }
        [field: SerializeField] public AdPlayerSettings Rewarded { get; private set; }
        [field: SerializeField] public AdPlayerSettings Banner { get; private set; }

        [field: Header("Settings")]
        [field: SerializeField] public bool TestMode { get; private set; } = true;
        [field: SerializeField] public bool EnablePerPlacementMode { get; private set; } = true;


        public string GameId =>
#if UNITY_EDITOR
            _androidGameId;
#else
            Application.platform switch
            {
                RuntimePlatform.Android => _androidGameId,
                RuntimePlatform.IPhonePlayer => _iOsGameId,
                _ => ""
            };
#endif
    }
}