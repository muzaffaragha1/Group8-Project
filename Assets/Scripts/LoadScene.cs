using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    IEnumerator processTask(int index)
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadSceneAsync(index);
    }



    public void sceneLoaded(int myScene)
    {
        StartCoroutine(processTask(myScene));
    }

    public void sceneLoad(int myScene)
    {
        SceneManager.LoadScene(myScene);
    }
}
