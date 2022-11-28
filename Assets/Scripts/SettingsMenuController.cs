using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenuController : MonoBehaviour
{
    //Volume_________
    //Turn on/off SFX, BG MUSIC
    //Vol Slider
    //Interface________
    //Font size (SLIDER)
    //Cursor size (SLIDER)
    //FONT CHANGE (CLICK BUTTON)
    [SerializeField] Font regFont, dyslexFont; //KEP IN MIND: This should apply to ALL TEXT
    [SerializeField] Slider volSlider, fontSizeSlider, cursorSizeSlider; //sliders to change values (CAN'T USE FOR CURSOR APPARENTLY)
    [SerializeField] GameObject AudioContObj, SettingsMenuDisplay, SoundsMenuDisplay, InterfaceMenuDisplay;
    AudioSource[] audioContSources;
    [SerializeField] Text testTextObj;
    //One for text (save that for last since that's the harder one)

    void Start()
    {
        audioContSources = AudioContObj.GetComponents<AudioSource>(); //Gets the audioSource components from the Audio Controller
        SettingsMenuDisplay.SetActive(false);
        //SoundsMenuDisplay.SetActive(false);
        //InterfaceMenuDisplay.SetActive(false);
    }

    void Update()
    {
        volSlider.value = audioContSources[0].volume; //leaving this just in case we decide to add BG music again
    }

    public void MuteSFX(){
        //Mute SFX
        audioContSources[1].mute = audioContSources[1].mute;
    }

    public void UnmuteSFX(){
        //Unmmute SFX 
        audioContSources[1].mute = !audioContSources[1].mute;
    }

    public void ChangeToRegularFont(){
        //CHANGE ALL TEXT TO REG FONT
        testTextObj.font = regFont;
    }

    public void ChangeToDyslexicFont(){
        //CHANGE ALL TEXT TO DYSLEX FONT
        testTextObj.font = dyslexFont;
    }

    public void ShowSettingsMenu(){
        //DISPLAYS SETTINGS MENU
        SettingsMenuDisplay.SetActive(true);
    
    }

    public void ShowAudioSettingsOptions(){
        //ALL AUDIO SETTINGS OPTIONS WILL BE HERE
        InterfaceMenuDisplay.SetActive(false);
        SoundsMenuDisplay.SetActive(true);

    }

    public void ShowInterfaceSettingsOptions(){
        //ALL INTERFACE SETTINGS OPTIONS WILL BE HERE
        InterfaceMenuDisplay.SetActive(true);
        SoundsMenuDisplay.SetActive(false);
    }


}
