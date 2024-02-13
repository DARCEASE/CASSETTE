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

    //Would it be possible to consolidate these and have them change depending on the scene it's in? YES!
    #region Ch1
    #region Novak_One
    public void Char1_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[0];
            Char1AS.clip = Novak_Audios[0];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char1_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[1];
            Char1AS.clip = Novak_Audios[1];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char1_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[2];
            Char1AS.clip = Novak_Audios[2];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char1_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[3];
            Char1AS.clip = Novak_Audios[3];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char1_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[4];
            Char1AS.clip = Novak_Audios[4];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char1_Audios_Six(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Novak_Texts[5];
            Char1AS.clip = Novak_Audios[5];
            currentAudioSource.clip = Char1AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion

    #region Julia
    public void Char2_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[0];
            Char2AS.clip = Julia_Audios[0];
            currentAudioSource.clip = Char2AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char2_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[1];
            Char2AS.clip = Julia_Audios[1];
            currentAudioSource.clip = Char2AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char2_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[2];
            Char2AS.clip = Julia_Audios[2];
            currentAudioSource.clip = Char2AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char2_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[3];
            Char2AS.clip = Julia_Audios[3];
            currentAudioSource.clip = Char2AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char2_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Julia_Texts[4];
            Char2AS.clip = Julia_Audios[4];
            currentAudioSource.clip = Char2AS.clip;  
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion

    #region Jim
    public void Char3_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Jim_Texts[0];
            Char3AS.clip = Jim_Audios[0];
            currentAudioSource.clip = Char3AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char3_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Jim_Texts[1];
            Char3AS.clip = Jim_Audios[1];
            currentAudioSource.clip = Char3AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char3_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Jim_Texts[2];
            Char3AS.clip = Jim_Audios[2];
            currentAudioSource.clip = Char3AS.clip;       
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char3_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Jim_Texts[3];
            Char3AS.clip = Jim_Audios[3];
            currentAudioSource.clip = Char3AS.clip;       
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char3_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Jim_Texts[4];
            Char3AS.clip = Jim_Audios[4];
            currentAudioSource.clip = Char3AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion

    #region Max
    public void Char4_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[0];
            Char4AS.clip = Max_Audios[0];
            currentAudioSource.clip = Char4AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char4_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[1];
            Char4AS.clip = Max_Audios[1];
            currentAudioSource.clip = Char4AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char4_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[2];
            Char4AS.clip = Max_Audios[2];
            currentAudioSource.clip = Char4AS.clip;       
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char4_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[3];
            Char4AS.clip = Max_Audios[3];
            currentAudioSource.clip = Char4AS.clip;       
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char4_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[4];
            Char4AS.clip = Max_Audios[4];
            currentAudioSource.clip = Char4AS.clip;  
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char4_Audios_Six(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Max_Texts[5];
            Char4AS.clip = Max_Audios[5];
            currentAudioSource.clip = Char4AS.clip;  
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion

    #region Mike
    public void Char5_Audios_One(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Mike_Texts[0];
            Char5AS.clip = Mike_Audios[0];
            currentAudioSource.clip = Char5AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char5_Audios_Two(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Mike_Texts[1];
            Char5AS.clip = Mike_Audios[1];
            currentAudioSource.clip = Char5AS.clip;
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char5_Audios_Three(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Mike_Texts[2];
            Char5AS.clip = Mike_Audios[2];
            currentAudioSource.clip = Char5AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char5_Audios_Four(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Mike_Texts[3];
            Char5AS.clip = Mike_Audios[3];
            currentAudioSource.clip = Char5AS.clip;        
            AP.a_duration = (int) currentAudioSource.time;
        }
    }

    public void Char5_Audios_Five(){
        if (scene.name == "OfficialStoryOne" || scene.name == "HybridStoryOne" || scene.name == "TESTStoryOneScene 1"){
            currentDisplayedText.text = Mike_Texts[4];
            Char5AS.clip = Mike_Audios[4];
            currentAudioSource.clip = Char5AS.clip; 
            AP.a_duration = (int) currentAudioSource.time;
        }
    }
    #endregion
    #endregion
}
