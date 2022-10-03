using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

// PLAN: For this to play and pause audio, and have the player scrub through audio if need be.
// If the player hits an icon, the player should pop up and play the audio for them.

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    //For audio, specifically showing the length of the clip, the current second it's on, minutes, and seconds
    [SerializeField] GameObject a_knob, a_durationBarBG, a_durationBar; //both the fill and handle slide area should move as the clip runs. //a_durationBar = fill line
    AudioSource a_source;
    AudioClip a_clip;
    int a_fullLength;
    int a_duration;
    int a_minutes;
    int a_seconds;
    bool _mouseOver;
    float simpleKnobVal, knobVal, minKnobVal, maxKnobVal, minKnobPosX, maxKnobPosX, knobPosX, barWidith;
    bool knobDragging;
    [SerializeField] Slider a_slider;

    //Just in case we want to display the name too (since they would click within the player's file for this)
    public TMP_Text a_titleText, a_timeText;


    //will allow the payer to scrub through it later
    void Start()
    {
        a_source = GetComponent<AudioSource>();
        a_clip = a_source.clip;
        a_source.Pause();
        ShowClipInfo();
        knobPosX = a_knob.transform.localPosition.x;
        barWidith = a_durationBarBG.transform.localScale.x;
        a_slider.maxValue = a_fullLength;
        //a_slider.onValueChanged.AddListener(delegate {OnMouseDrag();});
    }


    void Update()
    {
        /*
        if (!knobDragging){
            a_durationBar.transform.localScale = new Vector2(a_durationBar.transform.localScale.x, 0);
            a_knob.transform.localPosition = new Vector2(a_durationBar.transform.localPosition.x, knob.transform.localPosition.y);
        }*/

     
    }

    IEnumerator WaitForClipEnd(){ //Allows the player to see how far along in the audio clip they're in
        while (a_source.isPlaying){
            a_duration = (int)a_source.time;
            ShowDuration();
            yield return null;
        }
    }

    public void PlayAudio(){ //Plays audio until it reaches the end
 
        if (!a_source.isPlaying){
                a_source.Play();
                a_slider.handleRect.gameObject.transform.localScale = new Vector2(a_durationBar.transform.localScale.x, 0);
        }
        StartCoroutine(WaitForClipEnd());
    }

    public void PauseAudio(){ //Pauses the audio
        if (a_source.isPlaying){
            a_source.Pause();
        }
    }

    void ShowDuration(){ //Puts the milliseconds into minutes in seconds
        a_seconds = a_duration % 60;
        a_minutes = (a_duration / 60) % 60;
        a_slider.value = (float) a_duration;
        a_timeText.text = a_minutes + ":" + a_seconds.ToString("D2") + "/" + ((a_fullLength / 60) % 60) + ":" + (a_fullLength % 60).ToString("D2"); //D2 = 2 decimal points
    
        if (Input.GetMouseButtonDown(0)){
            a_slider.value = a_source.time;
            a_duration = a_source.time;


        }
    }

    void ShowClipInfo(){ //Shows the name of the clip and its length
        a_titleText.text = a_clip.name;
        a_fullLength = (int) a_clip.length;
    }
    /*
    public void OnKnobDrag(){
        Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(curScreenPoint);
        a_knob.transform.position = new Vector2(currentPos.x, currentPos.y);
        knobPosX = a_knob.transform.localPosition.x;
        if (knobPosX > maxKnobPosX) {knobPosX = maxKnobPosX;}
        if (knobPosX < maxKnobPosX) {knobPosX = minKnobPosX;}
        a_knob.transform.localPosition = new Vector2(knobPosX, 0);
        CalcSimpleKnobVal();
        a_durationBar.transform.localScale = new Vector3(simpleKnobVal * barWidith, a_durationBar.transform.localScale.y, 0);

    }

    void CalcSimpleKnobVal(){
        maxKnobVal = maxKnobPosX - minKnobPosX;
        knobVal = a_knob.transform.localPosition.x - minKnobPosX;
        simpleKnobVal = knobVal/ maxKnobVal;
    }

    void OnMouseDrag() {
        OnKnobDrag();
    }*/
}
