using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeToGameSceneScript : MonoBehaviour
{
    [SerializeField] CanvasGroup canvas;
    Scene scene;
    [SerializeField] Image TransitionOBJ;
    [SerializeField] float transitionTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(IntroLevel());
    }

    IEnumerator IntroLevel(){
        float t = 1;
        while ( t < transitionTime){ // 1 is less than 5
            t -= (Time.deltaTime*100);
            canvas.alpha = t;
            yield return null;
        }
    }
}
