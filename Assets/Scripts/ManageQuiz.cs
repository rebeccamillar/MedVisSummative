using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageQuiz : MonoBehaviour
{

    public List<GameObject> questionList;
    public int maxQuestionIndex = 5;
    public int myQuestionIndex = 0;
    [SerializeField]
    private GameObject scorePanel;

    // Start is called before the first frame update
    void Start()
    {
        OnClickNext();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNext()
    {  
        if(myQuestionIndex < maxQuestionIndex)
        {
        //retrieve random question from list 
        int index = Random.Range(0,questionList.Count);
        //set question to visible (set GO as Active)
        questionList[index].SetActive(true);
        //Remove object (question) from List
        questionList.RemoveAt(index);
        //increase myQuestion Index value
        myQuestionIndexindex +=1;
        }

        else
        {
            //Show score panel
            scorePanel.SetActive(true);
            Debug.Log("End")
        }

    }
    //*for(int i = 0; i < questionList.transform.childCount; i++){questionList.transform.GetChild(i).gameObject.SetActive(false);}//*
}
