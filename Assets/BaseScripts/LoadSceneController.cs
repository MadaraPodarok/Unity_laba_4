using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneController : MonoBehaviour
{
    public void LoadMenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }

    /*
    * Бродилка вид сбоку
    */
    public void LoadRoamScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("RoamScene");
    }
    
    /*
    * Экзамен от первого лица
    */
    public void LoadExamScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("ExamScene");
    }

    /*
    * Тренировка - перс бежим сам по поинтам
    */
    public void LoadTrainingScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TrainingScene");
    }

    public void LoadTerrainScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("TerrainScene");
    }
}
