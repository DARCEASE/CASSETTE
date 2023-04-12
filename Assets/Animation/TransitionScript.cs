using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TransitionScript : MonoBehaviour
{
 
    [SerializeField] CanvasGroup canvas;
    Scene scene;
    [SerializeField] Image TransitionOBJ;
    [SerializeField] float transitionTime;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void FadeOutScene(){
        StartCoroutine(IntroLevel());
    }

    public void ToNextScene(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    //One to Fade in...
    //One to Fade Out...

    IEnumerator IntroLevel(){
        float t = 1;
        while ( t < transitionTime){ // 1 is less than 5
            t -= (Time.deltaTime*100);
            canvas.alpha = t;
            yield return null;
        }
    }

    IEnumerator LoadLevel(int levelIndex){
        float t = 0;
        while ( t < transitionTime){
            t += Time.deltaTime;
            canvas.alpha = t/transitionTime;
            yield return null;
        }        

        if (levelIndex > 5){
            levelIndex = 0;
        } 
        SceneManager.LoadScene(levelIndex);
    }
}
