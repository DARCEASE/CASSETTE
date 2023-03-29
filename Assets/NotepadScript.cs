using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotepadScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rectX, rectY, rectW, rectH;
    GUIStyle currentStyle;
    [SerializeField] string userText = "Write notes here.";
    void Start()
    {
        //currentStyle.normal.background = Color.red;
    }

    // Update is called once per frame
    void OnGUI()
    {
        userText = GUI.TextArea(new Rect(rectX, rectY, rectW, rectH), userText);
        //GUI.skin.box.normal.color = Color.gray;
    }
}
