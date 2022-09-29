using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ProgressSlot : MonoBehaviour, IDropHandler
{
 
    public string staff3;
    public string barSliderValue;
    public TextMeshProUGUI bartext;
    public Slider bar;
    public float BarSkill;
    public GameObject avatar1;
    public GameObject avatar2;
    public GameObject avatar3;
    public GameObject avatar4;
    public GameObject avatar5;
    public GameObject avatar6;
    public GameObject avatar7;
    public GameObject avatar8;
    public GameObject avatar9;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("slot");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnBar = true;
            staff3 = eventData.pointerDrag.GetComponent<GameDragAndDrop>().gameObject.name;
            Debug.Log(staff3);

            if (staff3 == "avatar1")
            {
                BarSkill = Avatar1Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar1);
                }
            }

            if (staff3 == "Avatar2")
            {
                BarSkill = Avatar2Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar2);
                }
            }

            if (staff3 == "Avatar3")
            {
                BarSkill = Avatar3Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar3);
                }
            }

            if (staff3 == "Avatar4")
            {
                BarSkill = Avatar4Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar4);
                }
            }

            if (staff3 == "Avatar5")
            {
                BarSkill = Avatar5Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar5);
                }
            }

            if (staff3 == "Avatar6")
            {
                BarSkill = Avatar6Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar6);
                }
            }

            if (staff3 == "Avatar7")
            {
                BarSkill = Avatar7Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar7);
                }
            }

            if (staff3 == "Avatar8")
            {
                BarSkill = Avatar8Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar8);
                }
            }

            if (staff3 == "Avatar9")
            {
                BarSkill = Avatar9Skills.barSkill;
                if (BarSkill != 0)
                {
                    Debug.Log(BarSkill);
                    bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                    bar.value = bar.value + BarSkill;
                    barSliderValue = bar.value.ToString();
                    bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                    bartext.text = barSliderValue + "/10";
                    Destroy(avatar9);
                }
            }


        }
    }
}
