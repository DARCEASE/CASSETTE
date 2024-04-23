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

    }
    
    public void FadeOutScene(){
        //StartCoroutine(IntroLevel());
    }

    public void ToNextScene(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
 
    IEnumerator LoadLevel(int levelIndex){
        float t = 0;

        if (levelIndex > 7){
            levelIndex = 0;
        } 
        SceneManager.LoadScene(levelIndex, LoadSceneMode.Single);
        yield return null;
    }
}
