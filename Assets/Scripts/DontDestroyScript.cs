using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
This script is ONLY for keeping objs alive after someone hits replay. 
DON'T REMOVE/DESTROY IT OR ELSE ERRORS WILL HAPPEN!
**/

public class DontDestroyScript : MonoBehaviour
{
    Scene scene;
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        DontDestroyOnLoad(this.gameObject);

        /*if (scene.name == "TESTStoryOneScene 1" || scene.name == "TESTStoryTwoScene 1"){
            Debug.Log("Scene Name DDS: " + scene.name);
            this.gameObject.SetActive(true);
        } else{
        //if (scene.name == "ToStoryTwo" || scene.name == "EndScene"){
            this.gameObject.SetActive(false);
        } */   
    }
}
