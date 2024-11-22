using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLesionAnimation : MonoBehaviour
{
    public GameObject lesionAnimated; 

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = lesionAnimated.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnimation()
    {
        animator.SetBool("ActivateAnimation", true);
    }
}
