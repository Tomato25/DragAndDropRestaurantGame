using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class leaderboardScript : MonoBehaviour
{

    public TextMeshProUGUI firstScore;
    public string userNickname;


    // Start is called before the first frame update
    void Start()
    {
        userNickname = PlayerPrefs.GetString("nickname");
        Debug.Log(userNickname);
        firstScore.text = PlayerPrefs.GetString("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
