using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLeftEndoAnimation : MonoBehaviour
{
   public GameObject leftEndoAnimated; 

   public string triggerName = "PlayAnimation";

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = leftEndoAnimated.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnimation()
    {
        //animator.Play("ActivateAnimation", -1, 0.0f);
        animator.SetBool("ActivateAnimation", true);
        //animator.SetTrigger(triggerName);
    }


}
