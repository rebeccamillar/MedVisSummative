using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRightEndoAnimation : MonoBehaviour
{
    public GameObject rightEndoAnimated; 

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = rightEndoAnimated.GetComponent<Animator>();
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
