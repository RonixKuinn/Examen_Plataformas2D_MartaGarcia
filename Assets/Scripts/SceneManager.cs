using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagment : MonoBehaviour
{
    //public static GameManager instance;

    public void SceneLoader(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadVictory()
    {
        SceneManager.LoadScene("Victoria");
    }
}




































/*
    public void SceneLoader(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadVictory()
    {
        //WaitForSecondsRealtime(0.12);
        SceneManager.LoadScene("Victoria");
    }*/