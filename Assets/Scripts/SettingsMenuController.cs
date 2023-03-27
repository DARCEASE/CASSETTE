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

    //FONTS
    // Lexend (Basic Dyslex font)
    // Berk (Basic Reg font)
    // Apple (Basic Title font)
    // Lexend Bold (Dys Title font, make it bold AND italicized)

    [SerializeField] AudioController AC;
    [SerializeField] Slider intVolSlider; //sliders to change values (CAN'T USE FOR CURSOR APPARENTLY)
    [SerializeField] AudioSource char1Audio, char2Audio, char3Audio, char4Audio, char5Audio;
    [SerializeField] GameObject AudioContObj, SettingsMenuDisplay, SoundsMenuDisplay, InterfaceMenuDisplay, volSliderKnob;
    float simpleKnobVal, knobVal, minKnobVal, maxKnobVal, minKnobPosX, maxKnobPosX, knobPosX, barWidith;
    int fontSizeTitleReg = 70;
    int fontSizeTitleDys = 50;
    int fontSizeReg = 12;
    int fontSizeDys = 12;
    
    //Text varis
    bool isReg, isDyslex;
    [SerializeField] Font regFont, dyslexFont; //KEEP IN MIND: This should apply to ALL TEXT
    [SerializeField] TMP_FontAsset regFontTMP, dyslexFontTMP, intFontTMP;
    //[SerializeField] Text[] allTextObjects;
    //[SerializeField] TMP_Text[] allTMPTextObjects;

    //Character Texts (Interview Panels & Fill-in panels (includes choices))
    [SerializeField] Text[] allCharText; //CHar fill in Panel Info
    [SerializeField] TMP_Text[] allCharTMPText;

    //Button Text
    [SerializeField] Text[] CompText;
    [SerializeField] TMP_Text[] CompTMPText;
    
    //Title text
    [SerializeField] Text[] allTitleText;
    [SerializeField] TMP_Text[] allTitleTMPText;

    //InterviewPanel text
    [SerializeField] TMP_Text[] allInterviewTMPText;
 

    //One for text (save that for last since that's the harder one)

    void Start()
    {
        SettingsMenuDisplay.SetActive(false);
        //SoundsMenuDisplay.SetActive(false);
        //InterfaceMenuDisplay.SetActive(false);
        
        isReg = true;
        isDyslex = false;
        knobPosX = volSliderKnob.transform.localPosition.x;
        intVolSlider.maxValue = 1;
        knobPosX = 0.5f;
        intVolSlider.value = knobPosX;

    }

    void Update()
    {
        /*
        intVolSlider.value = char1Audio.volume;
        intVolSlider.value = char2Audio.volume;
        intVolSlider.value = char3Audio.volume;
        intVolSlider.value = char4Audio.volume;
        intVolSlider.value = char5Audio.volume;
        */
        char1Audio.volume = intVolSlider.value;
        char2Audio.volume = intVolSlider.value;
        char3Audio.volume = intVolSlider.value;
        char4Audio.volume = intVolSlider.value;
        char5Audio.volume = intVolSlider.value;

        /*
        for (int i = 0; i < 5; i++){
            intVolSlider.value =
        }*/

        //volSlider.value = audioContSources[0].volume; //leaving this just in case we decide to add BG music again
        if(Input.GetKeyDown(KeyCode.C) && isReg){
                ChangeToDyslexicFont();
    
        } else if(Input.GetKeyDown(KeyCode.C) && isDyslex){
                ChangeToRegularFont();
        }
    }

/*
    public void MuteBGMusic(){ //Mouse Click
        //Mute SFX
        AC.bg_source.mute = AC.bg_source.mute;
    }
*/
    public void ToggleBGMusic(){
        //Unmmute SFX 
        AC.bg_source.mute = !AC.bg_source.mute;
    }

    public void ToggleSFX(){
        //Unmmute SFX 
        AC.mouseA_source.mute = !AC.mouseA_source.mute;
    }

    void OnMouseDrag() {
        char1Audio.volume = intVolSlider.value;
        char2Audio.volume = intVolSlider.value;
        char3Audio.volume = intVolSlider.value;
        char4Audio.volume = intVolSlider.value;
        char5Audio.volume = intVolSlider.value;
        Debug.Log("Sliding");  
    }


    public void ChangeToRegularFont(){
        //CHANGE ALL TEXT TO REG FONT
        //testTextObj.font = regFont;
        isReg = true;
        isDyslex = false;
        //Char font
        for (int i = 0; i < allCharText.Length; i++){
            allCharText[i].font = regFont;
            if (allCharText[i].fontSize == fontSizeTitleDys){
                allCharText[i].fontSize = fontSizeTitleReg;
            }
            if (allCharText[i].fontSize == fontSizeDys){
                allCharText[i].fontSize = fontSizeReg;
            }

            Debug.Log("Char text " + i);
        }

        for (int i = 0; i < allCharTMPText.Length; i++){
            allCharTMPText[i].font = regFontTMP;
            if (allCharTMPText[i].fontSize == fontSizeTitleDys){
                allCharTMPText[i].fontSize = fontSizeTitleDys;
            }
            if (allCharTMPText[i].fontSize == fontSizeDys){
                allCharTMPText[i].fontSize = fontSizeReg;
            }
            Debug.Log("Char TMP " + i);
        }

        //Comp font
        /*
        for (int i = 0; i < CompText.Length; i++){
            CompText[i].font = regFont;
        }

        for (int i = 0; i < CompTMPText.Length; i++){
            CompTMPText[i].font = regFontTMP;
        }*/

        //TItle font
        for (int i = 0; i < allTitleText.Length; i++){
            allTitleText[i].font = regFont;
        }

        for (int i = 0; i < allTitleTMPText.Length; i++){
            allTitleTMPText[i].font = regFontTMP;
        }

        //Interview Font
        for (int i = 0; i < allInterviewTMPText.Length; i++){
            if (i % 3 == 0){
                allInterviewTMPText[i].font = regFontTMP;
            } else{
                allInterviewTMPText[i].font = intFontTMP;
            }
        }
    }

    public void ChangeToDyslexicFont(){
        //CHANGE ALL TEXT TO DYSLEX FONT
        //testTextObj.font = dyslexFont;

        isDyslex = true;
        isReg = false;
        
        //Char font
        for (int i = 0; i < allCharText.Length; i++){
            allCharText[i].font = dyslexFont;
            if (allCharText[i].fontSize == fontSizeTitleReg){
                allCharText[i].fontSize = fontSizeTitleDys;
            }//*/
            if (allCharText[i].fontSize == fontSizeReg){
                allCharText[i].fontSize = fontSizeDys;
            }
            Debug.Log("ALl Char Text " + i);
        }

        for (int i = 0; i < allCharTMPText.Length; i++){
            allCharTMPText[i].font = dyslexFontTMP;
            if (allCharTMPText[i].fontSize == fontSizeTitleReg){
                allCharTMPText[i].fontSize = fontSizeTitleDys;
            }
            if (allCharTMPText[i].fontSize == fontSizeReg){
                allCharTMPText[i].fontSize = fontSizeDys;
            }//*/
            Debug.Log("All Char TMP " + i);
        }

        //Comp font
        /*
        for (int i = 0; i < CompText.Length; i++){
            CompText[i].font = dyslexFont;
        }

        for (int i = 0; i < CompTMPText.Length; i++){
            CompTMPText[i].font = dyslexFontTMP;
        }*/

        //TItle font
        for (int i = 0; i < allTitleText.Length; i++){
            allTitleText[i].font = dyslexFont;
        }

        for (int i = 0; i < allTitleTMPText.Length; i++){
            allTitleTMPText[i].font = dyslexFontTMP;
        }

        //Interview Font
        for (int i = 0; i < allInterviewTMPText.Length; i++){
            if (i % 3 == 0){
                allInterviewTMPText[i].font = dyslexFontTMP;
            } else{
                allInterviewTMPText[i].font = dyslexFontTMP;
            }
        }
    }

    public void ShowSettingsMenu(){
        //DISPLAYS SETTINGS MENU
        SettingsMenuDisplay.SetActive(true);
    
    }

    public void CloseSettingsMenu(){
        //DISPLAYS SETTINGS MENU
        SettingsMenuDisplay.SetActive(false);
    
    }

    public void ShowAudioSettingsOptions(){
        //ALL AUDIO SETTINGS OPTIONS WILL BE HERE
        //InterfaceMenuDisplay.SetActive(false);
        //SoundsMenuDisplay.SetActive(true);

    }

    public void ShowInterfaceSettingsOptions(){
        //ALL INTERFACE SETTINGS OPTIONS WILL BE HERE
        //InterfaceMenuDisplay.SetActive(true);
        //SoundsMenuDisplay.SetActive(false);
    }


}
