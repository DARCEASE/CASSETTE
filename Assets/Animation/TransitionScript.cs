using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TransitionScript : MonoBehaviour
{
    [SerializeField] AnimationCurve ac;
    [SerializeField] CanvasGroup canvas;
    Scene scene;
    [SerializeField] Image TransitionOBJ;
    [SerializeField] float transitionTime;

    // Start is called before the first frame update
    void Start()
    {
        FadeOutScene();

    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.IsValid());
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
        float t = 0;
        while (t < 0.5f){
            t +=Time.deltaTime;
            yield return null;
        }
        t = transitionTime;
        while ( t > 0){ // 1 is less than 5
            t -= Time.deltaTime;
            canvas.alpha = ac.Evaluate(t/transitionTime);
            //Debug.Log("RUNNING HERE");
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
