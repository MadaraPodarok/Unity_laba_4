using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExitButtonController : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Выход из игры");
        EditorApplication.isPlaying = false;

        Application.Quit();
    }
}
