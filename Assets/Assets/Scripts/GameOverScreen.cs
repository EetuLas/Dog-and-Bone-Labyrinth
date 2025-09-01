using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] CanvasGroup _gameOverCG;

    void CanvasGroupSetState(CanvasGroup canvasGroup, bool state)
    {
        canvasGroup.alpha = state ? 1.0f : 0.0f;
        canvasGroup.interactable = state;
        canvasGroup.blocksRaycasts = state;
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CanvasGroupSetState(_gameOverCG, false);
        AudioManager.Instance.PlayMusic();
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        CanvasGroupSetState(_gameOverCG, false);
        SceneManager.LoadScene(0);
        AudioManager.Instance.PlayMusic();
    }
}
