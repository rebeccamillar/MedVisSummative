using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour
{
    public GameObject _ObjToLookAt;

    private Vector3 initPosition;
    private Quaternion initRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.RightArrow))
       {
        Debug.Log("Right Arrow Pressed");
        transform.Translate(0.1f, 0.0f, 0.0f, Space.World);
       } 
       else if (Input.GetKey(KeyCode.LeftArrow))
       {
        Debug.Log("Left Arrow Pressed");
        transform.Translate(-0.1f, 0.0f, 0.0f. Space.World);
       }
       if (Input.GetKey(KeyCode.UpArrow))
       {
        Debug.Log("Up Arrow Pressed");
        transform.Translate(0.0f, 0.1f, 0.0f, Spce.World);
       }
       else if (Input.GetKey(KeyCode.DownArrow))
       {
        Debug.Log("Down Arrow Pressed");
        tranform.Translate(0.0f, -0.1f, 0.0f, Space.World);
       }
       else {}

       transform.LookAr(_ObjToLookAt.transform.up);
    }

    public void ResetOnClick()
    {
        transform.position = initPosition;
        transform.rotation = initRotation;
    }
}
