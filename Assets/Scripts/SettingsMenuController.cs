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
    [SerializeField] GameObject AudioContObj, volSliderKnob;
    float simpleKnobVal, knobVal, minKnobVal, maxKnobVal, minKnobPosX, maxKnobPosX, knobPosX, barWidith;
    
    //Text varis
    bool isReg, isDyslex;
    [SerializeField] Font AppleFont, DyslexFont, BerkFont, PrintFont; //KEEP IN MIND: This should apply to ALL TEXT
    [SerializeField] TMP_FontAsset AppleFontTMP, DyslexFontTMP, BerkFontTMP, PrintFontTMP; //interview font
    //if Berk = 20, Dys = 15. If dys = 15, Berk = 20
    [SerializeField] int TESTBerkFontReg, TESTBerkFontDys;

 
    //Second Attempt
    //TMP objs
    [SerializeField] TMP_Text[] AppleSDFTMPObjs;
    [SerializeField] TMP_Text[] PrintCharTMPObjs;
    [SerializeField] TMP_Text[] BerkTMPObjs;

    //Text Objs
    [SerializeField] Text[] AppleSDFTextObjs, BerkTextObjs, PrintCharTextObjs;
 

    //One for text (save that for last since that's the harder one)

    void Start()
    {
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

     
        if(Input.GetKeyDown(KeyCode.C) && isReg){
                ChangeToDyslexicFont();
    
        } else if(Input.GetKeyDown(KeyCode.C) && isDyslex){
                ChangeToRegularFont();
        }
    }

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
        isReg = true;
        isDyslex = false;

        for (int i = 0; i < AppleSDFTMPObjs.Length; i++){

            AppleSDFTMPObjs[i].font = AppleFontTMP;
        }

        for (int i = 0; i < BerkTMPObjs.Length; i++){
            
            BerkTMPObjs[i].font = BerkFontTMP;

            if (BerkTMPObjs[i].fontSize <= TESTBerkFontReg && BerkTMPObjs[i].fontSize > 35){
                BerkTMPObjs[i].fontSize = 65;
                Debug.Log("1 BerkTMP to Dys Title Fonts: " + i);
            
            }if (BerkTMPObjs[i].fontSize <= TESTBerkFontReg && BerkTMPObjs[i].fontSize < 35){
                BerkTMPObjs[i].fontSize = TESTBerkFontReg;
            }

        }

        for (int i = 0; i < PrintCharTMPObjs.Length; i++){
            
            PrintCharTMPObjs[i].font = PrintFontTMP;
        }

        for (int i = 0; i < AppleSDFTextObjs.Length; i++){

            AppleSDFTextObjs[i].font = AppleFont;
        }

        for (int i = 0; i < BerkTextObjs.Length; i++){
            
            BerkTextObjs[i].font = BerkFont;

            if (BerkTextObjs[i].fontSize > 35){
                BerkTextObjs[i].fontSize = 65;
                Debug.Log("2 BerkText to Dys Title Fonts: " + i);

            } else if (BerkTextObjs[i].fontSize >= TESTBerkFontReg  && BerkTextObjs[i].fontSize < 35){
                BerkTextObjs[i].fontSize = TESTBerkFontReg;
            }

            
        }

        for (int i = 0; i < PrintCharTextObjs.Length; i++){
            
            PrintCharTextObjs[i].font = PrintFont;
        }
    }

    public void ChangeToDyslexicFont(){
        //CHANGE ALL TEXT TO DYSLEX FONT

        isDyslex = true;
        isReg = false;

        for (int i = 0; i < AppleSDFTMPObjs.Length; i++){

            AppleSDFTMPObjs[i].font = DyslexFontTMP;
        }

        for (int i = 0; i < BerkTMPObjs.Length; i++){
            
            BerkTMPObjs[i].font = DyslexFontTMP;

            if (BerkTMPObjs[i].fontSize >= TESTBerkFontDys && BerkTMPObjs[i].fontSize > 35){
                BerkTMPObjs[i].fontSize = 37;
                Debug.Log("3 BerkTMP to Dys Title Fonts: " + i);
            }

            if (BerkTMPObjs[i].fontSize >= TESTBerkFontDys && BerkTMPObjs[i].fontSize < 35){
                BerkTMPObjs[i].fontSize = TESTBerkFontDys;

            }

           
        }

        for (int i = 0; i < PrintCharTMPObjs.Length; i++){
            
            PrintCharTMPObjs[i].font = DyslexFontTMP;
        }

        for (int i = 0; i < AppleSDFTextObjs.Length; i++){

            AppleSDFTextObjs[i].font = DyslexFont;
        }

        for (int i = 0; i < BerkTextObjs.Length; i++){
            
            BerkTextObjs[i].font = DyslexFont;

            if (BerkTextObjs[i].fontSize >= TESTBerkFontDys && BerkTextObjs[i].fontSize > 35){
                BerkTextObjs[i].fontSize = 37;
                Debug.Log("4 BerkText to Dys Title Fonts: " + i);

            } else if (BerkTextObjs[i].fontSize >= TESTBerkFontDys && BerkTextObjs[i].fontSize < 35){
                BerkTextObjs[i].fontSize = TESTBerkFontDys;
            }
        }

        for (int i = 0; i < PrintCharTextObjs.Length; i++){
            
            PrintCharTextObjs[i].font = DyslexFont;
        }
    }

}
