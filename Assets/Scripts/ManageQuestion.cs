using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ManageQuestion : MonoBehaviour
{
    [SerializeField]
    private ToggleGroup myToggleGroup;

    [SerializeField]
    private GameObject userResponse;

    [SerializeField]
    private GameObject correctResponse;

    [SerializeField]
    private GameObject positiveFeedback;

    [SerializeField]
    private GameObject negativeFeedback;

    [SerializeField]
    private GameObject questionObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickConfirm()
    {
        //Retrieve the click response
        Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault();
        userResponse = selectedToggle.gameObject;

        //Set all toggles as non-interactable 
        for (int i = 0; i < myToggleGroup.transform.childCount; i++)
        {
            myToggleGroup.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }

        if (userResponse == correctResponse)
        {
            //Trigger POSITIVE feedback 
            positiveFeedback.SetActive(true);

            transform.parent.GetComponent<ManageQuiz>().score += 1;
        }
        else
        {
            //Trigger NEGATIVE feedback
            negativeFeedback.SetActive(true);
        }

        for(int i = 0; i < questionObj.transform.childCount; i++)
        {
            questionObj.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }
    }

}
