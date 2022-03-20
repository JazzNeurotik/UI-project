using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "Level2")
        {
            SceneTransition.SwitchToScene("Level1");
        }
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Level2");
    }
}
