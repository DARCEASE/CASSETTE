using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplaySnippets : MonoBehaviour
{
    //Multiple audio clips and their transcripts will be loaded here
    //Depending on the clip the player selects, it will play the audio and display the proper file that's needed.
    // ROTDORE:Make a system that stores the text and audio file that should appear when the player selects a certain button.
    
    Scene scene;
    [SerializeField] AudioPlayer AP;
    [SerializeField] AudioClip[] Novak_Audios, Jim_Audios, Julia_Audios, Max_Audios, Mike_Audios;
    [TextArea]
    [SerializeField] string[] Novak_Texts, Jim_Texts, Julia_Texts, Max_Texts, Mike_Texts;
    [SerializeField] TMP_Text currentDisplayedText;
    [SerializeField] AudioSource currentAudioSource, Char1AS, Char2AS, Char3AS, Char4AS, Char5AS;
    [SerializeField] AudioClip currentDisplayedAudio;
    //if player clicks on THIS button, THIS text will appear. Make a function that will change things once a player clicks on it.

    
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Novak_Audios_One(){
        currentDisplayedAudio = Novak_Audios[0];
        currentDisplayedText.text = Novak_Texts[0];
    }

    #region Julia
    public void Julia_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[0];
            Char2AS.clip = Julia_Audios[0];
            currentAudioSource.clip = Char2AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Julia_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[1];
            Char2AS.clip = Julia_Audios[1];
            currentAudioSource.clip = Char2AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Julia_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[2];
            Char2AS.clip = Julia_Audios[2];
            currentAudioSource.clip = Char2AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Julia_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[3];
            Char2AS.clip = Julia_Audios[3];
            currentAudioSource.clip = Char2AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Julia_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[4];
            Char2AS.clip = Julia_Audios[4];
            currentAudioSource.clip = Char2AS.clip;  
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion
}
