using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class TypewriterScript : MonoBehaviour
{
    [SerializeField] TMP_Text TMPReportOf;
    [SerializeField] TMP_Text TMPnameOfStory;
    string TMPfullTitle;
    Color32 colorC= new Color32(1,0,0,255);
    

    //For IEnum
    [SerializeField] TMP_Text introText;
    bool isTyping = false;
    bool cancelTyping = false;
    bool goToNext = false;
    bool isTalking = false;
    [SerializeField] float typeSpeed;
    TransitionScript TS;


    void Awake()
    {
        
        TMPfullTitle = TMPReportOf.text +'\n' + TMPnameOfStory.text; //puts a space for the story title
        TMPReportOf.color = Color.red;
        Debug.Log((TMPReportOf.color));
        StartCoroutine(TextScroll(TMPfullTitle));
    }

    private void Start() {

    }

    private void Update()
    {
        if (goToNext){
            TS.TransitionIn();
            SceneManager.LoadScene("StoryOneScene");

        }
        //DontDestroyOnLoad(this);
    }

    private IEnumerator TextScroll(string lineOfText) //Gives it that one character at a timeffect...
    {
        int letter = 0;
        introText.text = "";
        isTyping = true;
        cancelTyping = false;
        //yield return new WaitForSeconds(typeSpeed);
        while (isTyping && !cancelTyping && (letter < lineOfText.Length - 1))
        {
            introText.text += lineOfText[letter];
            letter += 1;
            yield return new WaitForSeconds(typeSpeed);
        }
        introText.text = lineOfText;
        isTyping = false;
        cancelTyping = false;

        if (letter == lineOfText.Length - 1){
            yield return new WaitForSeconds(6);
            goToNext = true;

        }
    }
}
