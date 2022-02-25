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
    private List<Button> buttonList = new List<Button>();
    [SerializeField]
    private GameObject panel;

    private void Awake()
    {
        buttonList.Add(choice1);
        buttonList.Add(choice2);
        buttonList.Add(choice3);
        buttonList.Add(choice4);

        this.loadQuestions();

    }

    

    public void checkAnswer(int id)
    {
        checkCorrectAnswer(id);
    }

    private void checkCorrectAnswer(int i)
    {
        string buttonText = buttonList[i].GetComponentInChildren<Text>().text;
        if (CategoryState.getQuestions().Count != 0 && buttonText.Equals(CategoryState.getCorrectAnswers()[CategoryState.index]))  
        {
            score++;
            turnGreen(i);
            StartCoroutine(loadNextQuestion());
        }
        else
        {
            turnRed(i);
            StartCoroutine(loadNextQuestion());
            // future: turn green the correct answer, for now just highlight red and move on
        }
    }

    // can create function to load a new question after a button has been pressed
    // can create function to randomize and set the choices

    private void turnRed(int i)
    {
        ColorBlock colors = buttonList[i].colors;
        colors.selectedColor = Color.red;
        colors.normalColor = Color.red;
        buttonList[i].colors = colors;
    }

    private void turnGreen(int i)
    {
        ColorBlock colors = buttonList[i].colors;
        colors.selectedColor = Color.green;
        colors.normalColor = Color.green;
        buttonList[i].colors = colors;
    }

    private void resetButtonColors()
    {
        for (int i = 0; i < 4; i++)
        {
            ColorBlock colors = buttonList[i].colors;
            colors.normalColor = Color.white;
            colors.selectedColor = Color.white;
            buttonList[i].colors = colors;
        }
    }

    private IEnumerator loadNextQuestion()
    {
        // turn on panel
        // categorystate.index++
        // wait 2.5 seconds
        // load next questions: loadQuestions()

        panel.gameObject.SetActive(true);
        if (CategoryState.getQuestions().Count > 0)
        {
            CategoryState.getQuestions().RemoveAt(0);
        }
        yield return new WaitForSeconds(2);
        this.resetButtonColors();
        panel.gameObject.SetActive(false);
        CategoryState.index++;
        loadQuestions();



    }


    private void loadQuestions()
    {
        int stateIndex = CategoryState.index;
        // check if index == 4
        // get score
        // switch to results scene
        // show how many correct out of 4
        // display text PERFECT 100%
        // text WOW 75%
        // You are smart! 50%
        // You can do better <50%
        // in results scene, make category state index 0

        // check if questions are empty, that means this category is done
        List<string> questions = CategoryState.getQuestions();
        if (questions.Count == 0)
        {
            // load results
            CategoryState.index = 0;
            SceneManager.LoadScene(2);
            Debug.Log("this section is done. no more questions");
        }
            
        Dictionary<int, string[]> options = CategoryState.getChoices();
        questionText.text = questions[0];
        // future: randomize options
        if (stateIndex <= 3 && questions.Count > 0)
        {
            Debug.Log("new options");
            choice1.GetComponentInChildren<Text>().text = options[stateIndex][0];
            choice2.GetComponentInChildren<Text>().text = options[stateIndex][1];
            choice3.GetComponentInChildren<Text>().text = options[stateIndex][2];
            choice4.GetComponentInChildren<Text>().text = options[stateIndex][3];
        }
        else
        {
            Debug.Log("not new options");
        }
        

    }



    public void backButton()
    {
        SceneManager.LoadScene(0);
    }

}
