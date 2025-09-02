using UnityEngine;
using TMPro;

public class ElapsedTimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float elapsedTime = 0f;
    private bool isRunning = false;

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            timerText.text = FormatTime(elapsedTime);
        }
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000);
        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    } 

    public void ResetTimer()
    {
        elapsedTime = 0f;
        timerText.text = FormatTime(elapsedTime);
    }

    public float GetElapsedTime() => elapsedTime;
}