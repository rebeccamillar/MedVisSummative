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
    private GameObject userResponse;

    [SerializeField]
    private GameObject correctResponse;

    [SerializeField]
    private GameObject NegativeFeedback;

    [SerializeField]
    private GameObject PositiveFeedback;

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

        if (userResponse == correctResponse)
        {
            //Trigger positive feedback 
            PositiveFeedback.SetActive(true);
        }
        else
        {
            //Trigger negative feedback
            NegativeFeedback.SetActive(true);
        }

        for(int i = 0; i < questionObj.transform.childCount; i++)
        {
            questionObj.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }
    }

}
