using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

namespace Ui
{
    internal class SettingsMenuView : MonoBehaviour
    {
        [SerializeField] private Button _close;

        public void Init(UnityAction close)=>
            _close.onClick.AddListener(close);

        public void OnDestroy()
        {
            _close.onClick.RemoveAllListeners();
        }
    }
}
