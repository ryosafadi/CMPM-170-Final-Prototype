using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    private float timerDuration = 30f;
    private TextMeshProUGUI timerText;

    private float timeRemaining;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timeRemaining = timerDuration;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            timeRemaining = 0;
            TimerEnded();
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.CeilToInt(timeRemaining);
        timerText.text = seconds.ToString();
    }

    void TimerEnded()
    {
        SceneManager.LoadScene("EndScene");
    }
}
