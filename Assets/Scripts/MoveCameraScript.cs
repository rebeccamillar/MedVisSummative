using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour
{
    public Transform _ObjToLookAt;
    private Vector3 initPosition;
    private Quaternion initRotation;
    private bool canBeInteracted;

    // Start is called before the first frame update
    void Start()
    {
        initPosition = transform.position;
        initRotation = transform.rotation;
    }
    // Update is called once per frame
    void Update()
    {
        if (canBeInteracted){
            
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    Debug.Log("Right Arrow Pressed");
                    //transform.Rotate(0.0f, -0.1f, 0.0f, Space.World);
                    transform.RotateAround(_ObjToLookAt.position, Vector3.up, 40 * Time.deltaTime);
                } 
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    Debug.Log("Left Arrow Pressed");
                    transform.RotateAround(_ObjToLookAt.position, Vector3.up, -40 * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.UpArrow) && Vector3.Distance(_ObjToLookAt.position, transform.position) > 0.5)
                {
                    Debug.Log("Up Arrow Pressed");
                    transform.Translate(((_ObjToLookAt.position - transform.position).normalized)* 4 *Time.deltaTime, Space.World);
                }
                else if (Input.GetKey(KeyCode.DownArrow) && Vector3.Distance(_ObjToLookAt.position, transform.position) < 1.5)
                {
                    Debug.Log("Down Arrow Pressed");
                    transform.Translate(((_ObjToLookAt.position - transform.position).normalized) *-4 * Time.deltaTime, Space.World);
                }
                else {}
                //transform.LookAt(_ObjToLookAt.transform);
            }
    }
    public void SetInteraction(bool m_interact)
    {    
        canBeInteracted = m_interact;
    }

    public void ResetOnClick()
    {
        transform.position = initPosition;
        transform.rotation = initRotation;
    }
    
}
