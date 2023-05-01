using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//This class handles the reader numbers and the audience analytics

public class AudienceFeedbackScript : MonoBehaviour
{
    public int entertainingVal, credibleVal, unbiasedVal;
    public int ratingNum; //vals to add and subtract
    public float floatAudienceVal;
    public int totalAudienceVal;
    const int DIVIDEBY100 = 100;
    public float E_equationVal, C_equationVal, U_equationVal;
    public TMP_Text textAudNum;
    float simpleKnobVal, knobVal, minKnobVal, maxKnobVal, minKnobPosX, maxKnobPosX, knobPosX, barWidith;

    //Sliders
    [SerializeField] Slider sliderEntertaining, sliderCredible, sliderUnbiased;
    
    void Start()
    {
        //Entertaining
        //entertainingVal = 41;
        sliderEntertaining.maxValue = 100;
        //Credible
        //credibleVal = 41;
        sliderCredible.maxValue = 100;
        //Unbiased
        //unbiasedVal = 41;
        sliderUnbiased.maxValue = 100;
        totalAudienceVal = PlayerPrefs.GetInt("AudienceFeedbackScore");
    }

    // Update is called once per frame
    public void Update()
    {
        FormulaCalculation();
        //Sliders for Audience Analytics
        sliderEntertaining.value = entertainingVal;
        sliderCredible.value = credibleVal;
        sliderUnbiased.value = unbiasedVal;
    }

    //Reader Numbers Calc
    public string FormulaCalculation(){

        E_equationVal = (float) (Mathf.Pow(entertainingVal, 2f)/DIVIDEBY100);
        C_equationVal = (float) (Mathf.Pow(credibleVal, 2f)/DIVIDEBY100);
        U_equationVal = (float) (Mathf.Pow(unbiasedVal, 2f)/DIVIDEBY100);

        floatAudienceVal = Mathf.Floor(((E_equationVal + C_equationVal + U_equationVal)/3) * 1000);
        totalAudienceVal = (int) floatAudienceVal;
        Debug.Log("The current audience score is " + totalAudienceVal);
        PlayerPrefs.SetInt("AudienceFeedbackScore", totalAudienceVal);
        textAudNum.text = totalAudienceVal.ToString();
        return textAudNum.text;
    }

    //Tonal boosts for papers
   /* public int TonalBoosts(){


    }*/

}
