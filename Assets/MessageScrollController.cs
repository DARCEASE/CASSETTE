using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageScrollController : MonoBehaviour
{
    //This script will allow the scrollbar for the messages app to reset it's self (1)
    // once the player clicks on another message to view.

    [SerializeField] Scrollbar sb;
    [SerializeField] FullDigitalUIBehavior uiB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    public void SBFunc(){
        sb.value = 1;
    }
}
