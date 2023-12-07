using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGame : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private Text timerText;
    [SerializeField] private Canvas dieCanvas;
 
    private float _timeLeft = 0f;
 
    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }
 
    private void Start()
    {
        _timeLeft = time;
        dieCanvas.enabled = false;
        StartCoroutine(StartTimer());
    }
 
    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
        {
            _timeLeft = 0;
        }
 
        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);

        
        if (_timeLeft <= 0) {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            dieCanvas.enabled = true;
        }

    }
}
