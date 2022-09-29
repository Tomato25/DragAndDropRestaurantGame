using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider progressBar;
    public Text progressText;
    public int points;
    public float progressvalue;
    public bool stopTimer;
    public float BarSkill;

    public void progress()
    {
        progressBar.maxValue = 10;
        progressvalue = progressBar.value;

    }

    // Update is called once per frame
    void Update()
    {
    }
}