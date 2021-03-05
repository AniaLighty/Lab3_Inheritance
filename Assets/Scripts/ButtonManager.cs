using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void HowTo()
    {
        SceneManager.LoadScene("HowTo");
    }

    public void Introduction()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Gameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    //Loads End Screen
    public void OnMouseDown()
    {
        SceneManager.LoadScene("EndScreen");
    }
}
