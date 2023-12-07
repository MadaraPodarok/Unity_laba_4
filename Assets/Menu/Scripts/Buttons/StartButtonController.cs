using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButtonController : MonoBehaviour
{
    [SerializeField] private Button roamGame;
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
        roamGame.animator.Play("RoamGameOpen");
        trainingGame.animator.Play("TrainingGameOpen");
        examGame.animator.Play("ExamGameOpen");
    }

    private void CloseListButton()
    {
        roamGame.animator.Play("RoamGameClose");
        trainingGame.animator.Play("TrainingGameClose");
        examGame.animator.Play("ExamGameClose");
    }
}
