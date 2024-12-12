using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateRightEndoAnimation : MonoBehaviour
{
    public GameObject rightEndoAnimated; 

    //public string triggerName = "PlayAnimation";

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

    private bool state = false;
    public void StartAnimation()
    {
        state = !state;
        animator.SetBool("ActivateAnimation", state);
        if (state == false)
        {
            StartCoroutine("WaitAndReLaunch");
        }
    }

    IEnumerator WaitAndReLaunch()
    {
        yield return new WaitForSeconds(1);
        state = !state;
        animator.SetBool("ActivateAnimation", state);
    }
}
