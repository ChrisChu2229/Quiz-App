using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryState : MonoBehaviour
{
    // future: make everything private and create getters and setters to update stuff


    // these string arrays holds all the questions
    public static string quizCategory;
    public static List<string> religionQuestions = new List<string>() { "Who is the god of war in Greek mythology?", "Which of these religions is believed to be the oldest?", "What is the correct name for a Jewish place of worship?", "Which of these Old Testament books comes first?" };
    public static List<string> mathQuestions = new List<string>() { "What is three fifth of 100?", "If David’s age is 27 years old in 2011. What was his age in 2003?", " I am a number. I have 7 in the ones place. I am less than 80 but greater than 70. What is my number?", "What is the value of x if x^2 = 169" };
    public static List<string> historyQuestions = new List<string>() { "Which of these countries did the Soviet Union NEVER invade?", "Who was the first person to orbit the Earth?", "Why did whalers hunt sperm whales?", "Which event triggered World War One?" };
    public static List<string> scienceQuestions = new List<string>() { "Where is DNA found inside a cell?", "What is an organism?", "What do we call the most basic structure of living things?", "In order to identify the probability of inheritance, we can use a __________." };
    public static List<string> computerScienceQuestions = new List<string>() { "Which among the following controls all parts of the computer and known as the brain of the computer?", "Who among the following first invented the computer mouse?", "The Fifth Generation Computer works on ...", "To store data and perform calculation, computer uses .......... number system." };
    
    
    public static int index = 0;
    private static Dictionary<string, int> totalResults = new Dictionary<string, int>();

    // these string arrays hold all the correct answers. they will be used to match the chosen answer later
    public static string[] correctReligionAnswer = new string[] { "Ares", "Hinduism", "Synagogue", "Numbers" };
    public static string[] correctScienceAnswer = new string[] { "Nucleus", "A living thing", "Cell", "Punnett Square" };
    public static string[] correctMathAnswer = new string[] { "60", "19 years", "77" , "13"};
    public static string[] correctHistoryAnswer = new string[] { "Sweden", "Yuri Gagarin", "For oil to make candles", "The assassination of Archduke Francis Ferdinand" };
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
        {3, new string[] {"Paper", "Calculator", "Computer", "Punnett Square" } }
    };

    public static Dictionary<int, string[]> mathChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"3", "5", "20", "60"} },
        {1, new string[] {"17 years", "37 years", "20 years", "19 years"} },
        {2, new string[] {"71", "73", "75", "77"}},
        {3, new string[] {"1", "13", "169", "338"}}
    };

    public static Dictionary<int, string[]> historyChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"Afghanistan", "Finland", "Poland", "Sweden" } },
        {1, new string[] {"Neil Armstrong", "Yuri Gagarin", "John Glenn", "Valentina Tereshkova"} },
        {2, new string[] {"For meat", "For oil to make candles", "For skin to make leather", "For sport"} },
        {3, new string[] { "The assassination of Archduke Francis Ferdinand", "German's invasion of Poland", "The sinking of Lusitania", "The tsar's refusal of an offer to visit Germany"} }
    };

    public static Dictionary<int, string[]> computerScienceChoices = new Dictionary<int, string[]>()
    {
        {0, new string[] {"RAM", "ROM", "CPU", "Processor"} },
        {1, new string[] {"Douglas C. Engelbart", "Adam Osbourne", "Adi Shamir", "Alain Glavieux" } },
        {2, new string[] {"Transistors", "Integrated circuit", "Artificial Intelligence", "Microprocessor"} },
        {3, new string[] {"Hexadecimal", "Octadecimal", "Binary", "Decimal"} }
    };
    



    public static Dictionary<string, string> results = new Dictionary<string, string>();


    public static void randomizeOptions()
    {
        Dictionary<int, string[]> randomOptions = getChoices();
        string[] choicesArr = randomOptions[index];


        for (int i = 0; i < 4; i++)
        {
            string temp = choicesArr[i];
            int randNum = UnityEngine.Random.Range(0, 4);
            choicesArr[i] = choicesArr[randNum];
            choicesArr[randNum] = temp;
        }


    }    



    public static string[] getCorrectAnswers()
    {
        switch (quizCategory)
        {
            case "Religion":
                return correctReligionAnswer;
            case "Science":
                return correctScienceAnswer;
            case "Math":
                return correctMathAnswer;
            case "History":
                return correctHistoryAnswer;
            case "Computer Science":
                return correctComputerScienceAnswers;
        }

        return null;
    }

    public static List<String> getQuestions()
    {
        switch (quizCategory)
        {
            case "Religion":
                return religionQuestions;
            case "Science":
                return scienceQuestions;
            case "Math":
                return mathQuestions;
            case "History":
                return historyQuestions;
            case "Computer Science":
                return computerScienceQuestions;
        }

        return null;
    }

    public static Dictionary<int, string[]> getChoices()
    {
        switch (quizCategory)
        {
            case "Religion":
                return religionChoices;
            case "Science":
                return scienceChoices;
            case "Math":
                return mathChoices;
            case "History":
                return historyChoices;
            case "Computer Science":
                return computerScienceChoices;
        }

        return null;
    }

    public static void addResults(int result)
    {
        if (!totalResults.ContainsKey(quizCategory))
        {
            totalResults.Add(quizCategory, result);
        }
    }

    public static int getScore()
    {
        return totalResults[quizCategory];
    }

}
