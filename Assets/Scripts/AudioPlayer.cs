using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

// PLAN: For this to play and pause audio, and have the player scrub through audio if need be.
// If the player hits an icon, the player should pop up and play the audio for them.

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    AudioSource a_source;
    //will allow the payer to scrub through it later
    void Start()
    {
        a_source = GetComponent<AudioSource>();
        a_source.Pause();
    }


    void Update()
    {
        //PlayAudio();
    }

    public void PlayAudio(){

        if (!a_source.isPlaying){
                a_source.Play();
            }
    }

    public void PauseAudio(){
        if (a_source.isPlaying){
                a_source.Pause();
            }
    }
}
