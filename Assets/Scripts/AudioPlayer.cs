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
    AudioSource a_source;
    AudioClip a_clip;
    int a_fullLength;
    int a_duration;
    int a_minutes;
    int a_seconds;

    //Just in case we want to display the name too (since they would click within the player's file for this)
    public TMP_Text a_titleText, a_timeText;


    //will allow the payer to scrub through it later
    void Start()
    {
        a_source = GetComponent<AudioSource>();
        a_clip = a_source.clip;
        a_source.Pause();
        ShowClipInfo();
        
    }


    void Update()
    {
        
        //PlayAudio();
    }

    IEnumerator WaitForClipEnd(){
        while (a_source.isPlaying){
            a_duration = (int)a_source.time;
            ShowDuration();
            yield return null;
        }
    }

    public void PlayAudio(){

        if (!a_source.isPlaying){
                a_source.Play();
            }
        StartCoroutine(WaitForClipEnd());
    }

    public void PauseAudio(){
        if (a_source.isPlaying){
                a_source.Pause();
            }
    }

    void ShowDuration(){
        a_seconds = a_duration % 60;
        a_minutes = (a_duration / 60) % 60;
        a_timeText.text = a_minutes + ":" + a_seconds.ToString("D2") + "/" + ((a_fullLength / 60) % 60) + ":" + (a_fullLength % 60).ToString("D2");
    }

    void ShowClipInfo(){
        a_titleText.text = a_clip.name;
        a_fullLength = (int) a_clip.length;
        //a_timeText.text = a_fullLength.ToString();

    }
}
