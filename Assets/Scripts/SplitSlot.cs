using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class SplitSlot : MonoBehaviour, IDropHandler
{

    public string staff;
    public bool droppedOnSplit;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public float BarSkill;
    public float DrinksSkill;
    public float CustomerSkill;
    public float FoodSkill;
    public Slider progressBar;
    public float progressvalue;
    public Slider drinks;
    public Slider food;
    public Slider customer;
    public Slider bar;
    public TextMeshProUGUI drinkstext;
    public string drinksSliderValue;
    public TextMeshProUGUI foodtext;
    public string barSliderValue;
    public TextMeshProUGUI customertext;
    public string customerSliderValue;
    public TextMeshProUGUI bartext;
    public string foodSliderValue;
    public string selectedStaffname;
    public string currentStaff;
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
            eventData.pointerDrag.GetComponent<GameDragAndDrop>().droppedOnSplit = true;
            staff = eventData.pointerDrag.GetComponent<GameDragAndDrop>().gameObject.name;
            Debug.Log(staff);

            if (staff == "avatar1")
            {

                FoodSkill = Avatar1Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar1Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar1Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar1Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar1);

            }

            if (staff == "Avatar2")
            {
            
                FoodSkill = Avatar2Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar2Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar2Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar2Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar2);

            }

            if (staff == "Avatar3")
            {

                FoodSkill = Avatar3Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar3Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar3Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar3Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar3);

            }

            if (staff == "Avatar4")
            {

                FoodSkill = Avatar4Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar4Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar4Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar4Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar4);

            }

            if (staff == "Avatar5")
            {

                FoodSkill = Avatar5Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar5Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar5Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar5Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar5);

            }

            if (staff == "Avatar6")
            {

                FoodSkill = Avatar6Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar6Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar6Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar6Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar6);

            }

            if (staff == "Avatar7")
            {

                FoodSkill = Avatar7Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar7Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar7Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar7Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar7);

            }

            if (staff == "Avatar8")
            {

                FoodSkill = Avatar8Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar8Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar8Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar8Skills.barSkill / 2;
                Debug.Log(BarSkill);
                bar = GameObject.FindGameObjectWithTag("barslider").GetComponent<Slider>();
                bar.value = bar.value + BarSkill;
                barSliderValue = bar.value.ToString();
                bartext = GameObject.FindGameObjectWithTag("bartext").GetComponent<TextMeshProUGUI>();
                bartext.text = barSliderValue + "/10";

                Destroy(avatar8);

            }

            if (staff == "Avatar9")
            {

                FoodSkill = Avatar9Skills.foodSkill / 2;
                Debug.Log(FoodSkill);
                food = GameObject.FindGameObjectWithTag("foodslider").GetComponent<Slider>();
                food.value = food.value + FoodSkill;
                foodSliderValue = food.value.ToString();
                foodtext = GameObject.FindGameObjectWithTag("foodtext").GetComponent<TextMeshProUGUI>();
                foodtext.text = foodSliderValue + "/10";

                CustomerSkill = Avatar9Skills.customerSkill / 2;

                Debug.Log(BarSkill);
                customer = GameObject.FindGameObjectWithTag("customerslider").GetComponent<Slider>();
                customer.value = customer.value + CustomerSkill;
                customerSliderValue = customer.value.ToString();
                customertext = GameObject.FindGameObjectWithTag("customertext").GetComponent<TextMeshProUGUI>();
                customertext.text = customerSliderValue + "/10";

                DrinksSkill = Avatar9Skills.drinksSkill / 2;
                Debug.Log(DrinksSkill);
                drinks = GameObject.FindGameObjectWithTag("drinksSlider").GetComponent<Slider>();
                drinks.value = drinks.value + DrinksSkill;
                drinksSliderValue = drinks.value.ToString();
                drinkstext = GameObject.FindGameObjectWithTag("drinkstext").GetComponent<TextMeshProUGUI>();
                drinkstext.text = drinksSliderValue + "/10";

                BarSkill = Avatar9Skills.barSkill / 2;
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