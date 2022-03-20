using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void onClickLoadScene()
    {
        SceneManager.LoadScene(4);
    }

        public void onClickShop()
    {
        SceneManager.LoadScene(2);
    }

    public void onClickChat()
    {
        SceneManager.LoadScene(3);
    }

    public void onClickMenu()
    {
        SceneManager.LoadScene(1);
    }
}
