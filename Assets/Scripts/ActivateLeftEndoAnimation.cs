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

    private bool state = false;
    public void StartAnimation()
    {
        state = !state;
        //! means not equal to the declared state so if state = false, !state = true
        animator.SetBool("ActivateAnimation", state);
        if (state == false)
        {
            StartCoroutine("WaitAndRelaunch");
        }

    }
    

    IEnumerator WaitAndRelaunch()
    {
        // suspend execution for 1 second
        yield return new WaitForSeconds(1);
        state = !state;
        animator.SetBool("ActivateAnimation", state);
    }




}
