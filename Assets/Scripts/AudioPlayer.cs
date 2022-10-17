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
        a_slider.value = knobPosX;

    }


    void Update()
    {
        /*
            a_durationBar.transform.localScale = new Vector2(a_durationBar.transform.localScale.x, 0);
            a_knob.transform.localPosition = new Vector2(a_durationBar.transform.localPosition.x, knob.transform.localPosition.y);
            */

     
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
            a_slider.onValueChanged.AddListener(delegate {OnMouseDrag();});

        }
        StartCoroutine(WaitForClipEnd());
    }

    public void PauseAudio(){ //Pauses the audio
        if (a_source.isPlaying){
            a_source.Pause();
            a_slider.onValueChanged.AddListener(delegate {OnMouseDrag();});

        }
    }

    public void RestartAudio(){
        a_duration = 0;
        a_source.time = (float) a_duration;
    }

    void ShowDuration(){ //Puts the milliseconds into minutes in seconds
        a_seconds = a_duration % 60;
        a_minutes = (a_duration / 60) % 60;
        a_slider.value = (float) a_duration;
        a_timeText.text = a_minutes + ":" + a_seconds.ToString("D2") + "/" + ((a_fullLength / 60) % 60) + ":" + (a_fullLength % 60).ToString("D2"); //D2 = 2 decimal points
    }

    void ShowClipInfo(){ //Shows the name of the clip and its length
        a_titleText.text = a_clip.name;
        a_fullLength = (int) a_clip.length;
    }
   
    void OnMouseDrag() {
        //if (Input.GetMouseButtonDown(0)){
             a_source.time = a_slider.value;
             Debug.Log("Sliding");
            
        //}
    }
}
