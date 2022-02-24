using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CategoryButtonControl : MonoBehaviour
{
    

    public void loadQuestion(string input)
    {
        switch (input)
        {
            case "Religion":
                Debug.Log("religion");
                CategoryState.quizCategory = "Religion";
                break;
            case "Science":
                Debug.Log("science");
                CategoryState.quizCategory = "Science";
                break;
            case "Math":
                CategoryState.quizCategory = "Math";
                break;
            case "History":
                CategoryState.quizCategory = "History";
                break;
            case "Computer Science":
                CategoryState.quizCategory = "Computer Science";
                break;
            case "All Questions":
                CategoryState.quizCategory = "All Questions";
                break;
            default:
                break;
        }





        SceneManager.LoadScene(1);
    }



}
