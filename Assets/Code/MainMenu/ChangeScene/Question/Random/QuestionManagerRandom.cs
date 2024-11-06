using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class QuestionManagerRandom : MonoBehaviour
{
    public QuestionFix[] questions;
    private static List<QuestionFix> unansweredQuestions;

    private QuestionFix currentQuestion;

    [SerializeField] 
    private Text factText;

    [SerializeField] 
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;

    [SerializeField] 
    private float timeBetweenQuestions = 1f;
    private void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<QuestionFix>();
        }

        SetCurrentQuestion();
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "WRONG";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG");
        }

        StartCoroutine(TransitionToNextQuestion()); 
    }

    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT!");
        }
        else
        {
            Debug.Log("WRONG");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
}
