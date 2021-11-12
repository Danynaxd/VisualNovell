using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void NewGame()
    {
        SceneManager.LoadScene ("NewGame");
    }

    public void Options()
    {
        SceneManager.LoadScene ("Options");
    }

    public void Credits()
    {
        SceneManager.LoadScene ("Credits");
    }

    public void Exit()
    {
        SceneManager.LoadScene ("NewGame");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene ("MainMenu");
    }

    public void StartStory()
    {
        SceneManager.LoadScene ("1_01");
    }

    public void NextLevel1_01_1()
    {
        SceneManager.LoadScene ("1_01_1");
    }

    public void NextLevel1_01_2()
    {
        SceneManager.LoadScene ("1_01_2");
    }

public void NextLevel1_01_3()
    {
        SceneManager.LoadScene ("1_01_3");
    }

    public void NextLevel1_01_4()
    {
        SceneManager.LoadScene ("1_01_4");
    }

    public void NextLevel1_01_5()
    {
        SceneManager.LoadScene ("1_01_5");
    }

    public void NextLevel1_01_6()
    {
        SceneManager.LoadScene ("1_01_6");
    }


    
}
