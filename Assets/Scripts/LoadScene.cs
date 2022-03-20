using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int sceneID;

    public Slider loadSlider;

    public void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync(sceneID);
        while (!oper.isDone)
        {
            float progress = oper.progress / 0.5f;
            loadSlider.value = progress;
            yield return null;
        }
    }
}
