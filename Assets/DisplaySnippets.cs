using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class DisplaySnippets : MonoBehaviour
{
    //Multiple audio clips and their transcripts will be loaded here
    //Depending on the clip the player selects, it will play the audio and display the proper file that's needed.
    // ROTDORE:Make a system that stores the text and audio file that should appear when the player selects a certain button.

    [SerializeField] AudioClip[] Novak_Audios, Jim_Audios, Julia_Audios, Max_Audios, Mike_Audios;
    [SerializeField] string[] Novak_Texts, Jim_Texts, Julia_Texts, Max_Texts, Mike_Texts;

    [SerializeField] TMP_Text currentDisplayedText;
    [SerializeField] AudioClip currentDisplayedAudio;


    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Novak_Audio_One(){
        currentDisplayedAudio = Novak_Audios[0];
        currentDisplayedText.text = Novak_Texts[0];
    }
}
