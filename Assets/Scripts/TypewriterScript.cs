using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypewriterScript : MonoBehaviour
{
    [SerializeField] string textReportOf;
    [SerializeField] string nameOfStory;

    TMP_Text TMPReportOf;
    TMP_Text TMPnameOfStory;
    TMP_Text TMPfullTitle;
    private int currentSpokenStrings = 0;
    [SerializeField] TMP_Text introText;
    bool isTyping = false;
    bool cancelTyping = false;
    bool goToNext = false;
    bool isTalking = false;
    public float typeSpeed;


    void Awake()
    {
        
    }

    private void Start() {
        TMPReportOf.text = textReportOf;
        TMPnameOfStory.text = nameOfStory;
        TMPReportOf.color = Color.red;
        TMPfullTitle.text = TMPReportOf.text + '\n' + TMPnameOfStory.text; //puts a space for the story title
        StartCoroutine(TextScroll(TMPfullTitle.text));
    }

    private void Update()
    {
        
    }

    private IEnumerator TextScroll(string lineOfText) //Gives it that one character at a timeffect...
    {
        int letter = 0;
        introText.text = "";
        isTyping = true;
        cancelTyping = false;
        yield return new WaitForSeconds(typeSpeed);
        while (isTyping && !cancelTyping && (letter < lineOfText.Length - 1))
        {
            introText.text += lineOfText[letter];
            letter += 1;
            yield return new WaitForSeconds(typeSpeed);
        }
        introText.text = lineOfText;
        isTyping = false;
        cancelTyping = false;
    }
}
