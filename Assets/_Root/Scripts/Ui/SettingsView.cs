using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace _Root.Scripts.Ui
{
    internal class SettingsView : MonoBehaviour
    {
        [SerializeField] private Button _buttonBack;
        
        public void Init(UnityAction backToMainMenu) =>
            _buttonBack.onClick.AddListener(backToMainMenu);

        public void OnDestroy() =>
            _buttonBack.onClick.RemoveAllListeners();
    }
}