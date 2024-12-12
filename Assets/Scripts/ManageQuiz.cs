using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageQuiz : MonoBehaviour
{

    public List<GameObject> questionList;
    [SerializeField]
    private List<GameObject> backupList;
    public int maxQuestionIndex = 5;
    public int myQuestionIndex = 0;
    [SerializeField]
    private GameObject scorePanel;
    [SerializeField]
    private GameObject scoreIndicator;

    private string initScoreText;

    public int score = 0;

    // Start is called before the first frame update
    void OnEnable()
    {
      
    }
    
    void Start()
    {
        for (int i = 0; i < questionList.Count; i++)
        {
            backupList.Add(questionList[i]);
        }

        initScoreText = scoreIndicator.GetComponent<TextMeshProUGUI>().text;
    }

    public void OnStartBt()
    {
        OnClickNext();
    }
    public void OnStartAgain()
    {
        //Clear List
        questionList.Clear();

        //Repopulate the list
        for (int i = 0; i < backupList.Count; i++)
        {
            questionList.Add(backupList[i]);
        }

        //reset the indicators
        myQuestionIndex = 0;
        score = 0;
        scoreIndicator.GetComponent<TextMeshProUGUI>().text = initScoreText;

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
            myQuestionIndex +=1;
        }
        else
        {
            //Show score panel
            scorePanel.SetActive(true);

            scoreIndicator.GetComponent<TextMeshProUGUI>().text = scoreIndicator.GetComponent<TextMeshProUGUI>().text + score;

            Debug.Log("End");
        }

    }
}

