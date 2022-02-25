using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryState : MonoBehaviour
{
    // these string arrays holds all the questions
    public static string quizCategory;
    public static string[] religionQuestions = { "Who is the god of war in Greek mythology?", "Which of these religions is believed to be the oldest?", "What is the correct name for a Jewish place of worship?", "Which of these Old Testament books comes first?" };
    public static string[] scienceQuestions = { "Where is DNA found inside a cell?", "What is an organism?", "What do we call the most basic structure of living things?", "In order to identify the probability of inheritance, we can use a __________." };
    public static string[] computerScienceQuestions = { "Which among the following controls all parts of the computer and known as the brain of the computer?", "Who among the following first invented the computer mouse?", "The Fifth Generation Computer works on ...", "To store data and perform calculation, computer uses .......... number system." };
    public static int index = 0;

    // these string arrays hold all the correct answers. they will be used to match the chosen answer later
    public static string[] correctReligionAnswer = new string[] { "Ares", "Hinduism", "Synagogue", "Numbers" };
    public static string[] correctScienceAnswer = new string[] { "Nucleus", "A living thing", "Cell", "Punnett Square" };
    public static string[] correctComputerScienceAnswers = new string[] { "CPU", "Douglas C. Engelbart", "Artificial Intelligence", "Binary" };

    // these dictionary with string array values hold all the choices available and the int key is the index of the question
    public static Dictionary<int, string[]> religionChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] { "Athena", "Ares", "Venus", "Mars" } },
        {1, new string[] { "Buddhism", "Hinduism", "Islam", "Christianity" } },
        {2, new string[] {"Mosque", "Synagogue", "Pagoda", "Church" } },
        {3, new string[] {"Numbers", "Judges", "Ecclesiastes", "Pslams"} }
    };
    public static Dictionary<int, string[]> scienceChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"Cytoplasm", "Nucleus", "Cell membrane", "Mitochondria"} },
        {1, new string[] {"A living thing", "An organ", "A toy", "Food"} },
        {2, new string[] {"DNA", "Skin", "Cell", "Life"} },
        {3, new string[] {"Paper", "Calculator", "Computer", "Punnet Square"} }
    };
    public static Dictionary<int, string[]> computerScienceChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"RAM", "ROM", "CPU", "Processor"} },
        {1, new string[] {"Douglas C. Engelbart", "Adam Osbourne", "Adi Shamir", "Alain Glavieux" } },
        {2, new string[] {"Transistors", "Integrated circuit", "Artificial Intelligence", "Microprocessor"} },
        {3, new string[] {"Hexadecimal", "Octadecimal", "Binary", "Decimal"} }
    };

    public static Dictionary<string, string> results = new Dictionary<string, string>();
    // add correct answers to its own array
    // and then make another array with the choices
    // after the person presses the choices, match the choice with the correct asnwers array
    // have an index number that will index through questions, correct answers and choices
    // might need to do array of arrays or dictionary or soemething

    public static string[] getCorrectAnswers()
    {
        switch (quizCategory)
        {
            case "Religion":
                return correctReligionAnswer;
            case "Science":
                return correctScienceAnswer;
            case "Computer Science":
                return correctComputerScienceAnswers;
        }

        return null;

    }
}
