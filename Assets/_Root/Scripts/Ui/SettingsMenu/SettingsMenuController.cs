using Profile;
using Tool;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Ui
{
    internal class SettingsMenuController : BaseController
    {
        private readonly ResourcePath _resurcePath = new ResourcePath("Prefab/UI/SettingsMenu");
        private readonly ProfilePlayer _profilePlayer;
        private readonly SettingsMenuView _view;

        public SettingsMenuController(Transform placeForUi, ProfilePlayer profilePlayer)
        {
            _profilePlayer = profilePlayer;
            _view = LoadView(placeForUi);
            _view.Init(BackToMenu);
            Debug.Log(_view);
        }

        private SettingsMenuView LoadView(Transform placeForUi)
        {
            GameObject prefab = ResourcesLoader.LoadPrefab(_resurcePath);
            GameObject objectView = Object.Instantiate(prefab, placeForUi);
            AddGameObject(objectView);

            return objectView.GetComponent<SettingsMenuView>();
        }

        private void BackToMenu() =>
            _profilePlayer.CurrentState.Value = GameState.Start;
    }
}
