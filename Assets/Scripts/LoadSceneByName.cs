using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    public void LoadSceneBtn(string sceneName)
    {
        StartCoroutine(DelayToLoadScene(sceneName));
    }

    private IEnumerator DelayToLoadScene(string sceneName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneName);

    }

}
