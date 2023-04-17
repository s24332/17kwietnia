using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{

    public static string playerName;

  public void CreatePlayer(TMP_InputField input)
    {

        if (input.text.Length == 0)
        {
            return;
        }

        SceneManager.LoadScene(1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {

    }

   
}
