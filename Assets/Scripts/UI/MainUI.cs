using System;
using Infrastructure;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class MainUI : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenuPanel;
        [SerializeField] private GameObject _levelPanel;

        [SerializeField] private Button _playButton;
        [SerializeField] private Button _quitButton;

        private GameObject[] _allPanels;

        private void OnEnable()
        {
            _allPanels = new[] { _mainMenuPanel, _levelPanel};
            
            _playButton.Add(PlayButton);
            //_quitButton.Add(QuitGame);
        }

        private void OnDisable()
        {
            _playButton.Remove(PlayButton);
            //_quitButton.Remove(QuitGame);

        }

        private void PlayButton()
        {
            HideAllPanels();
            OpenPanel(_levelPanel);
        }

        private void QuitGame() =>
            Application.Quit();

        public void OpenPanel(GameObject panelToOpen)
        {
            HideAllPanels();
            panelToOpen.SetActive(true);
        }

        public void Quit() =>
            Application.Quit();

        private void HideAllPanels()
        {
            foreach (GameObject panel in _allPanels)
                panel.SetActive(false);
        }
    }
}
