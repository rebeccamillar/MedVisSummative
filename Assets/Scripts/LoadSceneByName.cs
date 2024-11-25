using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByName : MonoBehaviour
{
    public void LoadSceneBtn(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}