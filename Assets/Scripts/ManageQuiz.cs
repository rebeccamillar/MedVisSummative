using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManageQuiz : MonoBehaviour
{

    public List<GameObject> questionList;
    public int maxQuestionIndex = 5;
    public int myQuestionIndex = 0;
    [SerializeField]
    private GameObject scorePanel;
    [SerializeField]
    private GameObject scoreIndicator;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        OnClickNext();
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

