using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultsController : MonoBehaviour
{
    [SerializeField]
    private Text resultsText;
    public void Awake()
    {
        this.checkScore();
    }

    private void checkScore()
    {
        int score = CategoryState.getScore();
        if (score == 4)
        {
            resultsText.text = "Results: " + score + "/4" + " Perfect";
        }
        else if (score == 3)
        {
            resultsText.text = "Results: " + score + "/4" + " WOW!";
        }
        else if (score == 2)
        {
            resultsText.text = "Results: " + score + "/4" + " You are smart!";
        }
        else
        {
            resultsText.text = "Results: " + score + "/4" + " You can do better!";
        }

    }
    public void goBackToQuizCategories()
    {
        SceneManager.LoadScene(0);
    }
}
