﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class gameManager5 : MonoBehaviour {

	
    public Sprite[] cardFace;
    public Sprite cardBack;
    public GameObject[] cards;
    public GameObject gameTime;
    public GameObject thisScene;
    public GameObject nextScene;
    public ScoreManager scoreManager;
    private bool _init  = false;
    private int _matches = 5;

    // Update is called once per frame

    private void Start()
    {
        _init = false;
        scoreManager = ScoreManager.Instance;
    }

    void Update () {
        
        if (!_init)
        {
            initializeCards();
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            checkCards();
        }
    }

    void initializeCards() {
        
        
        
        for (int id = 0; id < 2; id++) {
            for (int i = 1; i < 6 ; i++) {

                bool test = false;
                int choice = 0;
                while (!test) {
                    choice = Random.Range (0, cards.Length);
                    test = !(cards [choice].GetComponent<cardScript> ().initialized);
                }
                cards [choice].GetComponent<cardScript> ().cardValue = i;
                cards [choice].GetComponent<cardScript> ().initialized = true;
                
            }
        }

        foreach (GameObject c in cards)
        {
            c.GetComponent<cardScript>().setupGraphics();
        }

        if (!_init)
        {
            _init = true;
        }
    }

    public Sprite getCardBack() {
        return cardBack;
    }

    public Sprite getCardFace(int i) {
        return cardFace[i - 1];
    }

    void checkCards() {
        List<int> c = new List<int> ();

        for (int i = 0; i < cards.Length; i++) {
            if (cards[i].GetComponent<cardScript>().state == 1)
            {
                c.Add(i);
            }
        }

        if (c.Count == 2)
            cardComparison (c);
    }

    void cardComparison(List<int> c){
        cardScript.DO_NOT = true;

        int x = 0;

        if (cards [c [0]].GetComponent<cardScript> ().cardValue == cards [c [1]].GetComponent<cardScript> ().cardValue) {
            x = 2;
            _matches--;
            scoreManager.plusScoreLevel03();
            if (_matches == 0)
            {
               nextScene.SetActive(true);
               thisScene.SetActive(false);
            }
                
        }


        for (int i = 0; i < c.Count; i++) {
            cards [c [i]].GetComponent<cardScript> ().state = x;
            cards [c [i]].GetComponent<cardScript> ().falseCheck ();
        }
	
    }

    private void NextMatch()
    {
        SceneManager.LoadScene("");
    }
    
    
 
    
}
