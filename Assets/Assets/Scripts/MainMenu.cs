using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] CanvasGroup _mainMenuButtonsCG;
    [SerializeField] CanvasGroup _quitConfirmationCG;
    [SerializeField] CanvasGroup _openSettingsMenuCG;


    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void CanvasGroupSetState(CanvasGroup canvasGroup, bool state)
    {
        canvasGroup.alpha = state ? 1.0f : 0.0f;
        canvasGroup.interactable = state;
        canvasGroup.blocksRaycasts = state;
    }

    public void OpenQuitInformation()
    {
        CanvasGroupSetState(_mainMenuButtonsCG, false);
        CanvasGroupSetState(_quitConfirmationCG, true);
    }

    public void CloseQuitInformation()
    {
        CanvasGroupSetState(_mainMenuButtonsCG, true);
        CanvasGroupSetState(_quitConfirmationCG, false);
    }

    public void OpenSettingsMenu()
    {
        CanvasGroupSetState(_mainMenuButtonsCG, false);
        CanvasGroupSetState(_openSettingsMenuCG, true);
    }

    public void CloseSettingsMenu()
    {
        CanvasGroupSetState(_mainMenuButtonsCG, true);
        CanvasGroupSetState(_openSettingsMenuCG, false);
    }
}
