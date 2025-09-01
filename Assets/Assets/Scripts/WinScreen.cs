using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] CanvasGroup _winScreenCG;

    void CanvasGroupSetState(CanvasGroup canvasGroup, bool state)
    {
        canvasGroup.alpha = state ? 1.0f : 0.0f;
        canvasGroup.interactable = state;
        canvasGroup.blocksRaycasts = state;
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        CanvasGroupSetState(_winScreenCG, false);
        SceneManager.LoadScene(0);
    }
}
