using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider TimeBar;
    public Text TimeText;
    public float gameTime;
    public Slider drinks;
    public Slider food;
    public Slider customer;
    public Slider bar;
    public bool stopTimer;
    public float score;
    float time;
    public string score1;
    public GameObject finalePanel;
    public GameObject finalPanelGO;
    public void timer()
    {
        stopTimer = false;
        TimeBar.maxValue = gameTime;
        TimeBar.value = gameTime;
        float foodValue = food.value;
        float customerValue = customer.value;
        float barValue = bar.value;
        float drinksValue = drinks.value;


    }

    public void StartTimer()
    {
        stopTimer = false;
        
    }


    // Update is called once per frame
    public void Update()
    {

        float foodValue = food.value;
        float customerValue = customer.value;
        float barValue = bar.value;
        float drinksValue = drinks.value;


        time = gameTime - Time.time;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time - minutes * 60f);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            Time.timeScale = 0f;
            score = seconds * 10;
            Debug.Log(score);



            finalPanelGO.SetActive(true);

            score1 = score.ToString();
            PlayerPrefs.SetString("highscore", score1);
        }

        if (stopTimer == false)
        {
            TimeText.text = textTime;
            TimeBar.value = time;
        }

        if (foodValue >= 10 && customerValue >= 10 && barValue >= 10 && drinksValue >= 10)
        {
            stopTimer = true;
            Time.timeScale = 0f;
            score = seconds * 10;
            Debug.Log(score);

            

            finalePanel.SetActive(true);
            
            score1 = score.ToString();
            PlayerPrefs.SetString("highscore", score1);


        }


    }


}
