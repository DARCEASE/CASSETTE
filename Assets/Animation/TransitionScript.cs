using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TransitionScript : MonoBehaviour
{
        [SerializeField] CanvasGroup canvas;
    [SerializeField] bool fadeIn, fadeOut;
    Scene scene;
    [SerializeField] Image TransitionOBJ;
    [SerializeField] float TimetoFade;

    // Start is called before the first frame update
    void Start()
    {
        FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if (fadeIn == true){
            if (canvas.alpha < 1){
                canvas.alpha += TimetoFade * Time.deltaTime;
                if (canvas.alpha >= 1){
                    fadeIn = false;
                }
            }
        }
        if (fadeOut == true){
            if (canvas.alpha >= 0){
                canvas.alpha -= TimetoFade * Time.deltaTime;
                if (canvas.alpha == 0){
                    fadeOut = false;
                }
            }
        }
    }
    
    public void FadeIn(){
        fadeIn = true;
        Debug.Log("Fading in");
    }

    public void FadeOut(){
        fadeOut = true;
        Debug.Log("Fading out");
    }
}
