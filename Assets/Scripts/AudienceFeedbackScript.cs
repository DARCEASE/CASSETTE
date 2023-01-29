using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AudienceFeedbackScript : MonoBehaviour
{
    public int entertainingVal, credibleVal;
    public int unbiasedVal = 100;
    public int ratingNum; //vals to add and subtract
    public float floatAudienceVal;
    public int totalAudienceVal;
    const int DIVIDEBY100 = 100;
    public float E_equationVal, C_equationVal, U_equationVal;
    public TMP_Text textAudNum;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public string FormulaCalculation(){

        E_equationVal = (float) (Mathf.Pow(entertainingVal, 2f) /DIVIDEBY100);
        C_equationVal = (float) (Mathf.Pow(credibleVal, 2f)/DIVIDEBY100);
        U_equationVal = (float) (Mathf.Pow(unbiasedVal, 2f)/DIVIDEBY100);

        floatAudienceVal = Mathf.Floor(((E_equationVal + C_equationVal + U_equationVal)/3) * 1000);
        Debug.Log("The current audience score is " + totalAudienceVal);
        totalAudienceVal = (int) floatAudienceVal;
        textAudNum.text = FormulaCalculation().ToString();
        return textAudNum.text;
    }
}
