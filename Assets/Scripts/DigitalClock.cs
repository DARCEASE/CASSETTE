using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DigitalClock : MonoBehaviour
{
    private Text textClock; //Desktop Clock 

    // Start is called before the first frame update
    void Start()
    {
        textClock = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;// take the current time of day right now and grab that 
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        textClock.text = hour + ":" + minute; // what the string will display
        
    }

    string LeadingZero(int n) // Time tracker for clock - method takes as input an integer and returns a string of this number with leading zeros added to the left, if the value was less than 10
    {
        return n.ToString().PadLeft(2, '0');
    }
}
