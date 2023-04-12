using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TransitionScript : MonoBehaviour
{
    private string currentState;
    private Animator animator;
    public Animation FadeOut;

    [SerializeField] CanvasGroup canvas;

    Scene scene;

    bool turnOff;

    [SerializeField] Image TransitionOBJ;

    [SerializeField] float transitionTime;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        scene = SceneManager.GetActiveScene();
        turnOff = false;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (scene.name == "StoryOneScene" || scene.name == "StoryTwoScene" ){
            if (FadeOut.isPlaying == true){ //if finished
                TransitionOBJ.enabled = true;
            } else{
                TransitionOBJ.enabled = false;
            }
        }*/
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
        while ( t < transitionTime){
            t -= Time.deltaTime;
            canvas.alpha = t/transitionTime;
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
