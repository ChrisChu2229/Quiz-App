using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionController : MonoBehaviour
{
    [SerializeField]
    private Text questionText;
    [SerializeField]
    private Text choice1;
    [SerializeField]
    private Text choice2;
    [SerializeField]
    private Text choice3;
    [SerializeField]
    private Text choice4;

    private void Awake()
    {
        switch(CategoryState.quizCategory)
        {
            case "Religion":
                Debug.Log("you have chosen religion questions");
                loadReligionQuestions();
                break;
            case "Science":
                Debug.Log("you have chosen science questions");
                loadScienceQuestions();
                break;
            default:
                Debug.Log("you chose nothing");
                break;
        }
    }

    private void loadReligionQuestions()
    {
        int stateIndex = CategoryState.index;
        questionText.text = CategoryState.religionQuestions[stateIndex];
        choice1.text = CategoryState.religionChoices[stateIndex][0];
        choice2.text = CategoryState.religionChoices[stateIndex][1];
        choice3.text = CategoryState.religionChoices[stateIndex][2];
        choice4.text = CategoryState.religionChoices[stateIndex][3];


    }

    // can create function to load a new question after a button has been pressed
    // can create function to randomize and set the choices
    private void loadScienceQuestions()
    {
        int stateIndex = CategoryState.index;
        questionText.text = CategoryState.scienceQuestions[stateIndex];
        choice1.text = CategoryState.scienceChoices[stateIndex][0];
        choice2.text = CategoryState.scienceChoices[stateIndex][1];
        choice3.text = CategoryState.scienceChoices[stateIndex][2];
        choice4.text = CategoryState.scienceChoices[stateIndex][3];
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }

}
