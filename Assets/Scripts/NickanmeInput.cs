using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NickanmeInput : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public TMP_InputField userInput;

    public void setName()
    {
        userName.text = userInput.text;
        Debug.Log(userName.text);
        PlayerPrefs.SetString("nickname", userName.ToString());
    }
   
}
