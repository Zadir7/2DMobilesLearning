using System;
using UnityEngine;

namespace _Root.Scripts.Services.Ads.Settings
{
    [Serializable]
    internal class AdPlayerSettings
    {
        [field: SerializeField] public bool Enabled { get; private set; }
        [SerializeField] private string _androidId;
        [SerializeField] private string _iosId;

        public string Id =>
#if UNITY_EDITOR
            _androidId;
#else
            Application.platform switch
            {
                RuntimePlatform.Android => _androidId,
                RuntimePlatform.IPhonePlayer => _iosId,
                _ => ""
            };
#endif
    }
}