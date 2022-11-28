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

    [SerializeField] Slider volSlider, fontSizeSlider, cursorSizeSlider;
    [SerializeField] AudioSource BGAudio, mouseSFX; 
    [SerializeField] Button fontChangeButton, SFXButton;
    [SerializeField] GameObject[] settingOptionsHolder;
    //One for text (save that for last since that's the harder one)

    void Start()
    {
        volSlider.value = BGAudio.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
