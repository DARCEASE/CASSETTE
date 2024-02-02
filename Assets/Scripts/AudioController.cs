using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    public AudioSource bg_source, mouseA_source, newspaperPrint_source;
    public Button SubmitButton;

    void Start()
    {
        //SubmitButton.onClick.AddListener(PrintSound());
        //bg_source.Play(); //if the game restarts, restart the clip for now
    }

    void Update()
    {
        StartCoroutine(MakeSound());
    }

    IEnumerator MakeSound(){ //Allows the sound to play. DO NOT REMOVE!
        if (Input.GetMouseButtonDown(0)){
            mouseA_source.Play();
            yield return new WaitForSeconds(2);
        }
    }

}
