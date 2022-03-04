using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int scoreIncrement = 10;
    [SerializeField] private int scoreMultiplier = 100;

    private bool isAlive;
    private float timerValue;
    private int scoreValue;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log("There is already an instance of GameManager. Destroying this instance!");
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        isAlive = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (isAlive) TickTimer();
       if (isAlive) IncrementScore();
    }

    void TickTimer()
    {
        timerValue += Time.deltaTime;
        TimeSpan ts = TimeSpan.FromSeconds(timerValue);
        timerText.text = "Time Elapsed: " + ts.ToString(@"mm\:ss\:fff");
    }

    void IncrementScore()
    {
        scoreValue += Mathf.FloorToInt((scoreIncrement * Time.deltaTime) * scoreMultiplier);
        scoreText.text = "Score: " + scoreValue.ToString();
    }

    public bool GetIsAlive()
    {
        return isAlive;
    }

    public void SetIsAlive(bool newValue)
    {
        isAlive = newValue;
    }

}
