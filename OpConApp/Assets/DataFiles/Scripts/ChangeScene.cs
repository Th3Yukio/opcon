using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void analyzer()
    {
        SceneManager.LoadScene("Analyzer");
    }
    
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

   public void closeapp()
    {
        Application.Quit();
        Debug.Log("Exit Button pressed");
    }
}
