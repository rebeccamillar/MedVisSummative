using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAdhesionAnimation : MonoBehaviour
{
    public GameObject AdhesionAnimated; 

    //public string triggerName = "PlayAnimation2";

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = AdhesionAnimated.GetComponent<Animator>();
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
            StartCoroutine("WaitAndRelaunch");
        }
    }

    IEnumerator WaitAndRelaunch()
    {
        yield return new WaitForSeconds(1);
        state = !state;
        animator.SetBool("ActivateAnimation", state);
    }
}
