using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryState : MonoBehaviour
{
    public static string quizCategory;
    public static string[] religionQuestions = { "Who is the god of war in Grek mythology?", "Which of these religions is believed to be the oldest?" };
    public static string[] scienceQuestions = { "Where is DNA found inside a cell?", "What is an organism?" };
    public static int index = 0;

    public struct answers
    {
        int correctAnswer;
        string[] differentAnswers;

        public answers(int c, string[] answer)
        {
            correctAnswer = c;
            differentAnswers = answer;
        }
    }

    public static string[] correctReligionAnswer = new string[] { "Ares", "Hinduism" };
    public static string[] correctScienceAnswer = new string[] { "Nucleus", "A living thing" };

    public static Dictionary<int, string[]> religionChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] { "Athena", "Ares", "Venus", "Mars" } },
        {1, new string[] { "Buddhism", "Hinduism", "Islam", "Christianity" } }
    };
    public static Dictionary<int, string[]> scienceChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"Cytoplasm", "Nucleus", "Cell membrane", "Mitochondria"} },
        {1, new string[] {"A living thing", "An organ", "A toy", "Food"} }
    };
    // add correct answers to its own array
    // and then make another array with the choices
    // after the person presses the choices, match the choice with the correct asnwers array
    // have an index number that will index through questions, correct answers and choices
    // might need to do array of arrays or dictionary or soemething

    //answers a = new answers(2, new string[] { "a", "b" });
    //public static List<answers> religionAnswers = new List<answers>() { new answers(2, new string[] { "a", "b", "c" } };

}
