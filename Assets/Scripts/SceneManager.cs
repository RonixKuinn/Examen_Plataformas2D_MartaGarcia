using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagment : MonoBehaviour
{
    //public static GameManager instance;
    private int coins = 0;
    [SerializeField] Text coinText;

    public void AddCoin()
    {
        coins++;        //es lo mismo que "coin +=1;"
        coinText.text = coins.ToString();

        /*if(coins = 4)
        {
            LoadVictory();
        }*/
    }

    public void SceneLoader(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void LoadVictory()
    {
        //WaitForSecondsRealtime(0.12);
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