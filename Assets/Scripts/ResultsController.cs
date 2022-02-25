using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultsController : MonoBehaviour
{
    public void goBackToQuizCategories()
    {
        SceneManager.LoadScene(0);
    }
}
