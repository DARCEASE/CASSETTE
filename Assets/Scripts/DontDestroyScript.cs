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
    /*
    public static DontDestroyScript Instance;

    void Awake(){
        if (Instance == null){
            Instance = this;
            return;
        }
        Destroy (gameObject);
    }
    */
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
