using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotepadScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject notepadPanel;
    [SerializeField] float rectW, rectH, testVal;
    GUIStyle currentStyle;
    [SerializeField] string userText = "Write notes here.";
    void Start()
    {
        //currentStyle.normal.background = Color.red;
    }

    // Update is called once per frame
    void OnGUI()
    {
        userText = GUI.TextArea(new Rect(notepadPanel.transform.position.x / testVal, notepadPanel.transform.position.y / testVal, rectW, rectH), userText);
        //GUI.skin.box.normal.color = Color.gray;
    }
}
