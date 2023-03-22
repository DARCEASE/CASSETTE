using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    public AudioSource bg_source, mouseA_source;

    void Start()
    {
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
