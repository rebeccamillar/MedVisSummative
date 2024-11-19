using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void QuitAppButton()
    {
        Application.Quit();
        Debug.Log("App has quit");
    }

}
