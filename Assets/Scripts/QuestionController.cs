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
    private Button choice1;
    [SerializeField]
    private Button choice2;
    [SerializeField]
    private Button choice3;
    [SerializeField]
    private Button choice4;
    private int score;
    private List<Button> list = new List<Button>();
    

    private void Awake()
    {
        list.Add(choice1);
        list.Add(choice2);
        list.Add(choice3);
        list.Add(choice4);
        switch (CategoryState.quizCategory)
        {
            case "Religion":
                Debug.Log("you have chosen religion questions");
                loadReligionQuestions();
                break;
            case "Science":
                Debug.Log("you have chosen science questions");
                loadScienceQuestions();
                break;
            case "Computer Science":
                loadComputerScienceQuestions();
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
        choice1.GetComponentInChildren<Text>().text = CategoryState.religionChoices[stateIndex][0];
        choice2.GetComponentInChildren<Text>().text = CategoryState.religionChoices[stateIndex][1];
        choice3.GetComponentInChildren<Text>().text = CategoryState.religionChoices[stateIndex][2];
        choice4.GetComponentInChildren<Text>().text = CategoryState.religionChoices[stateIndex][3];

    }

    public void checkAnswer(int id)
    {
        checkCorrectAnswer(id);
    }

    private void checkCorrectAnswer(int i)
    {
        string buttonText = list[i].GetComponentInChildren<Text>().text;
        if (buttonText.Equals(CategoryState.getCorrectAnswers()[CategoryState.index]))
        {
            Debug.Log("correct answer");
            turnGreen(i);
        }
        else
        {
            Debug.Log("wrong answer");
            turnRed(i);
        }
    }
    // can create function to load a new question after a button has been pressed
    // can create function to randomize and set the choices

    private void turnRed(int i)
    {
        ColorBlock colors = list[i].colors;
        colors.selectedColor = Color.red;
        list[i].colors = colors;
    }

    private void turnGreen(int i)
    {
        ColorBlock colors = list[i].colors;
        colors.selectedColor = Color.green;
        list[i].colors = colors;
    }
    private void loadScienceQuestions()
    {
        int stateIndex = CategoryState.index;
        questionText.text = CategoryState.scienceQuestions[stateIndex];
        choice1.GetComponentInChildren<Text>().text = CategoryState.scienceChoices[stateIndex][0];
        choice2.GetComponentInChildren<Text>().text = CategoryState.scienceChoices[stateIndex][1];
        choice3.GetComponentInChildren<Text>().text = CategoryState.scienceChoices[stateIndex][2];
        choice4.GetComponentInChildren<Text>().text = CategoryState.scienceChoices[stateIndex][3];
    }

    private void loadComputerScienceQuestions()
    {
        int stateIndex = CategoryState.index;
        questionText.text = CategoryState.computerScienceQuestions[stateIndex];
        choice1.GetComponentInChildren<Text>().text = CategoryState.computerScienceChoices[stateIndex][0];
        choice2.GetComponentInChildren<Text>().text = CategoryState.computerScienceChoices[stateIndex][1];
        choice3.GetComponentInChildren<Text>().text = CategoryState.computerScienceChoices[stateIndex][2];
        choice4.GetComponentInChildren<Text>().text = CategoryState.computerScienceChoices[stateIndex][3];
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
    }

}
