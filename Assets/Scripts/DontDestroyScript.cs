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

    void Start(){

    }
    
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        
        if (scene.name != "EndScene")
            DontDestroyOnLoad(this.gameObject);
    }
}
