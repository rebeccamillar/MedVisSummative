using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageQuiz : MonoBehaviour
{
    [SerializeField]

    private List<GameObject> questionList;

    [SerializeField]

    private int questionsCollectionSize = 3;

    private int index = 0;

    [SerializeField]
    private GameObject finalPanel;

    [SerializeField]
    private GameObject questionPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickNext()
    {
        for(int i = 0; i < questionPanel.transform.childCount; i++)
        {
            questionPanel.transform.GetChild(i).gameObject.SetActive(false);
        }
        
        if(index < questionsCollectionSize)
        {
        //pick up random question from list and set GO as Active
        int listID = Random.Range(0,questionList.Count);
        questionList[listID].SetActive(true);
        //Remove object from List
        questionList.RemoveAt(listID);
        index +=1;
        }
        else
        {
            finalPanel.SetActive(true);
        }

    }
}
