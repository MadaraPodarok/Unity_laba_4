using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    [SerializeField] private Button fpsGame;
    [SerializeField] private Button trainingGame;
    [SerializeField] private Button examGame;
    private bool isOpen = false;

    public void ClickListButton()
    {
        if (isOpen)
        {
            CloseListButton();
        }
        else
        {
            OpenListButton();
        }
        isOpen = !isOpen;
    }

    private void OpenListButton()
    {
        fpsGame.animator.Play("FPSGameOpen");
        trainingGame.animator.Play("TrainingGameOpen");
        examGame.animator.Play("ExamGameOpen");
    }

    private void CloseListButton()
    {
        fpsGame.animator.Play("FPSGameClose");
        trainingGame.animator.Play("TrainingGameClose");
        examGame.animator.Play("ExamGameClose");
    }
}
