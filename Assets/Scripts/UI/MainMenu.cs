using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Audio()
    {
        SceneManager.LoadScene("Audio");
    }

}
