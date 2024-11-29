using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour
{
    private Vector3 initPosition;
    private Quaternion initRotation;

    // Start is called before the first frame update
    void Start()
    {
       initPosition = transform.position;
       initRotation = transform.rotation; 
    }

    public void ResetOnClick()
    {
        transform.position = initPosition;
        transform.rotation = initRotation;
    }
}
