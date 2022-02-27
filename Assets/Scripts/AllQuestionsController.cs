using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllQuestionsController : MonoBehaviour
{
    public void goBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
