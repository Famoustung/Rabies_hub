using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;


public class QuestionManagerFix : MonoBehaviour
{
    public QuestionFix[] questions;
    public static List<QuestionFix> unansweredQuestions;
    public int A = 0;
    public int score = 0;
    public QuestionFix currentQuestion;
    [SerializeField] private GameObject endScore;
    [SerializeField] public Image factImage;
    public float timeBetweenQuestions = 1f;
    
    public TextMeshProUGUI[] scoreText;
    
    private int currentQuestionIndex = -1;

    public AudioSource[] QuestionSound;
    
    public GameObject[] Answer;

    public GameObject ScoreNotYet;

    public bool IsPreTest;

    
    

    //public SaveTest saveTest;
    
    private void Start()
    {
        Time.timeScale = 1f;
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<QuestionFix>();
        }
        SetCurrentQuestion();
    }

    private void Update()
    {
        
        scoreText[0].text = "Score: " + score + " / 11";
        scoreText[1].text = "Score: " + score + " / 11";
        if (A > 11) {
            Debug.Log("Over test");
            if (score > 7)
            {
                endScore.SetActive(true);
            }

            if (score < 8)
            {
                ScoreNotYet.SetActive(true);
            }
        }

    }

    public void SetCurrentQuestion()
    {
        int QuestionIndex = 0;
        currentQuestion = unansweredQuestions[QuestionIndex];
        factImage.sprite = currentQuestion.factImage;
        currentQuestionIndex = QuestionIndex;
        
        QuestionSound[A].Play();
    }

    public IEnumerator TransitionToNextQuestion()
    {

        if (currentQuestionIndex < 11)
        {
            // Get the next unanswered question.
            currentQuestionIndex++;
            currentQuestion = unansweredQuestions[currentQuestionIndex];
            factImage.sprite = currentQuestion.factImage;

            if (QuestionSound[A - 1].isPlaying)
            {
                QuestionSound[A - 1].Pause();
            }

            if (A < 11)
            {
                QuestionSound[A].Play();
            }

            yield return new WaitForSeconds(timeBetweenQuestions);

        }

            // If there are no more unanswered questions, then activate the end score screen.
            if (unansweredQuestions.Count-1 == currentQuestionIndex)
            {
            if (score > 7)
            {
                endScore.SetActive(true);
            }

            if (score < 8)
            {
                ScoreNotYet.SetActive(true);
            }

        }
       
    }

    public void UserSelectTrue()
    {
        A++;
        
            if (currentQuestion.isTrue)
            {
                score++;

                Debug.Log("CORRECT!");
                Debug.Log(score);

                if (IsPreTest)
                 {
                    SavePretest(true);
                 }
                if(!IsPreTest) 
                {
                    SavePosttest(true);
                }
            if (A == unansweredQuestions.Count - 1)
                {
                    if (score > 7)
                    {
                        endScore.SetActive(true);
                    }
                    if (score < 8)
                    {
                        ScoreNotYet.SetActive(true);
                    }
                }
                StartCoroutine(TransitionToNextQuestion());
            }
            else
            {
            if (A <= 11)
            {
                Answer[A - 1].SetActive(true);

                if (QuestionSound[A - 1].isPlaying)
                {
                    QuestionSound[A - 1].Pause();
                }
            }
                 if (IsPreTest)
                 {
                 SavePretest(false);
                 }
                 if (!IsPreTest) 
                 {
                SavePosttest(false);
                 }
            }
        
    }

    public void UserSelectFalse()
    {
        A++;
        
            if (!currentQuestion.isTrue)
            {
                score++;
                 Debug.Log("CORRECT!");

                 Debug.Log(score);

                 if (IsPreTest)
                 {
                SavePretest(true);
                 }
                 if(!IsPreTest)
                 {
                SavePosttest(true);
                 }
                 if (A == unansweredQuestions.Count - 1)
                    {
                if (score > 7)
                {
                    endScore.SetActive(true);
                }
                if (score < 8)
                {
                    ScoreNotYet.SetActive(true);
                }
                     }
                          StartCoroutine(TransitionToNextQuestion());
            }
            else
            {
            if (A <= 11)
            {
                Answer[A - 1].SetActive(true);

                if (QuestionSound[A - 1].isPlaying)
                {
                    QuestionSound[A - 1].Pause();
                }
            }
                if (IsPreTest)
                 {
                SavePretest(false);
                 }
                if (!IsPreTest)
                 {
                SavePosttest(false);
                 }
             }
        
    }


    public void CloseAnswer()
    {
        Answer[A-1].SetActive(false);
        if (A == unansweredQuestions.Count - 1) 
        {
            if (score > 7)
            {
                endScore.SetActive(true); 
            }
            if (score < 8)
            {
                ScoreNotYet.SetActive(true);
            }
        }
        StartCoroutine(TransitionToNextQuestion());
    }

    public void SavePretest(bool IsCorrect)
    {
        if (IsCorrect)
        {
            switch (A)
            {
                case 1:
                    PlayerPrefs.SetInt("pretest1", 1);
                    Debug.Log("PreTest ��� 1 �� 1 ");
                    break;
                case 2:
                    PlayerPrefs.SetInt("pretest2", 1);
                    Debug.Log("PreTest ��� 2 �� 1 ");
                    break;
                case 3:
                    PlayerPrefs.SetInt("pretest3", 1);
                    Debug.Log("PreTest ��� 3 �� 1 ");
                    break;
                case 4:
                    PlayerPrefs.SetInt("pretest4", 1);
                    Debug.Log("PreTest ��� 4 �� 1 ");
                    break;
                case 5:
                    PlayerPrefs.SetInt("pretest5", 1);
                    Debug.Log("PreTest ��� 5 �� 1 ");
                    break;
                case 6:
                    PlayerPrefs.SetInt("pretest6", 1);
                    Debug.Log("PreTest ��� 6 �� 1 ");
                    break;
                case 7:
                    PlayerPrefs.SetInt("pretest7", 1);
                    Debug.Log("PreTest ��� 7 �� 1 ");
                    break;
                case 8:
                    PlayerPrefs.SetInt("pretest8", 1);
                    Debug.Log("PreTest ��� 8 �� 1 ");
                    break;
                case 9:
                    PlayerPrefs.SetInt("pretest9", 1);
                    Debug.Log("PreTest ��� 9 �� 1 ");
                    break;
                case 10:
                    PlayerPrefs.SetInt("pretest10", 1);
                    Debug.Log("PreTest ��� 10 �� 1 ");
                    break;
                case 11:
                    PlayerPrefs.SetInt("pretest11", 1);
                    Debug.Log("PreTest ��� 11 �� 1 ");
                    break;
                case 12:
                    PlayerPrefs.SetInt("pretest12", 0);
                    Debug.Log("PreTest ��� 12 �� 0 ");
                    break;
                case 13:
                    PlayerPrefs.SetInt("pretest13", 0);
                    Debug.Log("PreTest ��� 13 �� 0 ");
                    break;
                case 14:
                    PlayerPrefs.SetInt("pretest14", 0);
                    Debug.Log("PreTest ��� 14 �� 0 ");
                    break;
                case 15:
                    PlayerPrefs.SetInt("pretest15", 0);
                    Debug.Log("PreTest ��� 15 �� 0 ");
                    break;
            }
            

        }
        else if (!IsCorrect)
        {
            switch (A)
            {
                case 1:
                    PlayerPrefs.SetInt("pretest1", 0);
                    Debug.Log("PreTest ��� 1 �� 0 ");
                    break;
                case 2:
                    PlayerPrefs.SetInt("pretest2", 0);
                    Debug.Log("PreTest ��� 2 �� 0 ");
                    break;
                case 3:
                    PlayerPrefs.SetInt("pretest3", 0);
                    Debug.Log("PreTest ��� 3 �� 0 ");
                    break;
                case 4:
                    PlayerPrefs.SetInt("pretest4", 0);
                    Debug.Log("PreTest ��� 4 �� 0 ");
                    break;
                case 5:
                    PlayerPrefs.SetInt("pretest5", 0);
                    Debug.Log("PreTest ��� 5 �� 0 ");
                    break;
                case 6:
                    PlayerPrefs.SetInt("pretest6", 0);
                    Debug.Log("PreTest ��� 6 �� 0 ");
                    break;
                case 7:
                    PlayerPrefs.SetInt("pretest7", 0);
                    Debug.Log("PreTest ��� 7 �� 0 ");
                    break;
                case 8:
                    PlayerPrefs.SetInt("pretest8", 0);
                    Debug.Log("PreTest ��� 8 �� 0 ");
                    break;
                case 9:
                    PlayerPrefs.SetInt("pretest9", 0);
                    Debug.Log("PreTest ��� 9 �� 0 ");
                    break;
                case 10:
                    PlayerPrefs.SetInt("pretest10", 0);
                    Debug.Log("PreTest ��� 10 �� 0 ");
                    break;
                case 11:
                    PlayerPrefs.SetInt("pretest11", 0);
                    Debug.Log("PreTest ��� 11 �� 0 ");
                    break;
                case 12:
                    PlayerPrefs.SetInt("pretest12", 0);
                    Debug.Log("PreTest ��� 12 �� 0 ");
                    break;
                case 13:
                    PlayerPrefs.SetInt("pretest13", 0);
                    Debug.Log("PreTest ��� 13 �� 0 ");
                    break;
                case 14:
                    PlayerPrefs.SetInt("pretest14", 0);
                    Debug.Log("PreTest ��� 14 �� 0 ");
                    break;
                case 15:
                    PlayerPrefs.SetInt("pretest15", 0);
                    Debug.Log("PreTest ��� 15 �� 0 ");
                    break;
            }

        }


    }

    public void SavePosttest(bool IsCorrect)
    {
        if (IsCorrect)
        {
            switch (A)
            {
                case 1:
                    PlayerPrefs.SetInt("posttest1", 1);
                    Debug.Log("PostTest ��� 1 �� 1 ");
                    break;
                case 2:
                    PlayerPrefs.SetInt("posttest2", 1);
                    Debug.Log("PostTest ��� 2 �� 1 ");
                    break;
                case 3:
                    PlayerPrefs.SetInt("posttest3", 1);
                    Debug.Log("PostTest ��� 3 �� 1 ");
                    break;
                case 4:
                    PlayerPrefs.SetInt("posttest4", 1);
                    Debug.Log("PostTest ��� 4 �� 1 ");
                    break;
                case 5:
                    PlayerPrefs.SetInt("posttest5", 1);
                    Debug.Log("PostTest ��� 5 �� 1 ");
                    break;
                case 6:
                    PlayerPrefs.SetInt("posttest6", 1);
                    Debug.Log("PostTest ��� 6 �� 1 ");
                    break;
                case 7:
                    PlayerPrefs.SetInt("posttest7", 1);
                    Debug.Log("PostTest ��� 7 �� 1 ");
                    break;
                case 8:
                    PlayerPrefs.SetInt("posttest8", 1);
                    Debug.Log("PostTest ��� 8 �� 1 ");
                    break;
                case 9:
                    PlayerPrefs.SetInt("posttest9", 1);
                    Debug.Log("PostTest ��� 9 �� 1 ");
                    break;
                case 10:
                    PlayerPrefs.SetInt("posttest10", 1);
                    Debug.Log("PostTest ��� 10 �� 1 ");
                    break;
                case 11:
                    PlayerPrefs.SetInt("posttest11", 1);
                    Debug.Log("PostTest ��� 11 �� 1 ");
                    break;
                case 12:
                    PlayerPrefs.SetInt("posttest12", 1);
                    Debug.Log("PostTest ��� 12 �� 1 ");
                    break;
                case 13:
                    PlayerPrefs.SetInt("posttest13", 1);
                    Debug.Log("PostTest ��� 13 �� 1 ");
                    break;
                case 14:
                    PlayerPrefs.SetInt("posttest14", 1);
                    Debug.Log("PostTest ��� 14 �� 1 ");
                    break;
                case 15:
                    PlayerPrefs.SetInt("posttest15", 1);
                    Debug.Log("PostTest ��� 15 �� 1 ");
                    break;
            }


        }
        else if (!IsCorrect)
        {
            switch (A)
            {
                case 1:
                    PlayerPrefs.SetInt("posttest1", 0);
                    Debug.Log("PostTest ��� 1 �� 0 ");
                    break;
                case 2:
                    PlayerPrefs.SetInt("posttest2", 0);
                    Debug.Log("PostTest ��� 2 �� 0 ");
                    break;
                case 3:
                    PlayerPrefs.SetInt("posttest3", 0);
                    Debug.Log("PostTest ��� 3 �� 0 ");
                    break;
                case 4:
                    PlayerPrefs.SetInt("posttest4", 0);
                    Debug.Log("PostTest ��� 4 �� 0 ");
                    break;
                case 5:
                    PlayerPrefs.SetInt("posttest5", 0);
                    Debug.Log("PostTest ��� 5 �� 0 ");
                    break;
                case 6:
                    PlayerPrefs.SetInt("posttest6", 0);
                    Debug.Log("PostTest ��� 6 �� 0 ");
                    break;
                case 7:
                    PlayerPrefs.SetInt("posttest7", 0);
                    Debug.Log("PostTest ��� 7 �� 0 ");
                    break;
                case 8:
                    PlayerPrefs.SetInt("posttest8", 0);
                    Debug.Log("PostTest ��� 8 �� 0 ");
                    break;
                case 9:
                    PlayerPrefs.SetInt("posttest9", 0);
                    Debug.Log("PostTest ��� 9 �� 0 ");
                    break;
                case 10:
                    PlayerPrefs.SetInt("posttest10", 0);
                    Debug.Log("PostTest ��� 10 �� 0 ");
                    break;
                case 11:
                    PlayerPrefs.SetInt("posttest11", 0);
                    Debug.Log("PostTest ��� 11 �� 0 ");
                    break;
                case 12:
                    PlayerPrefs.SetInt("posttest12", 0);
                    Debug.Log("PostTest ��� 12 �� 0 ");
                    break;
                case 13:
                    PlayerPrefs.SetInt("posttest13", 0);
                    Debug.Log("PostTest ��� 13 �� 0 ");
                    break;
                case 14:
                    PlayerPrefs.SetInt("posttest14", 0);
                    Debug.Log("PostTest ��� 14 �� 0 ");
                    break;
                case 15:
                    PlayerPrefs.SetInt("posttest15", 0);
                    Debug.Log("PostTest ��� 15 �� 0 ");
                    break;
            }

        }


    }
}
