using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DoubleClick : MonoBehaviour //Selectable //, IPointerClickHandler, IPointerDownHandler
{
    public Button[] DClickButtons;
    public Button testButton;
    public int tapTime;
    public float resetTimer;
    public bool doubleClicked = false;

    void Start() {
        testButton = GetComponent<Button>();
        testButton.onClick.AddListener(CheckForDoubleClick);    
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)){
            tapTime++;
        }

        if (tapTime != 2){
            doubleClicked = false;
            Debug.Log("NO DCLICK");
        }

        if (tapTime > 2){
            Debug.Log("Double");
            tapTime = 0;
            doubleClicked = false;
        }

        
    }

    public void CheckForDoubleClick(){

        if (tapTime == 2){
            Debug.Log("Is true");
            doubleClicked = true;
        }
        
    }



    /*
    private float doubleClickTimeLimit = 0.25f;
    public bool clickedOnce = false, doubleClicked = false;
    public string singleTapMove;
    public string doubleTapMove;
    float count = 0f;

    public void startClick(){
        StartCoroutine (ClickEvent());
    }

    public IEnumerator ClickEvent()
    {
        if (!clickedOnce && count < doubleClickTimeLimit) {
            clickedOnce = true;
        } else {
            clickedOnce = false;
            yield break; //If the button is pressed twice, don't allow the second function call to fully execute.
        }
        yield return new WaitForEndOfFrame();

        while(count < doubleClickTimeLimit)
        {
            if(!clickedOnce)
            {
                DoubleClickCheck();
                count = 0f;
                clickedOnce = false;
                yield break;
            }
            count += Time.deltaTime;// increment counter by change in time between frames
            yield return null; // wait for the next frame
        }
        SingleClickCheck();
        count = 0f;
        clickedOnce = false;
    }

    public void SingleClickCheck()
    {
        Debug.Log("Single Click");
    }

   public void DoubleClickCheck()
    {
        doubleClicked = true;
        Debug.Log("Double Click");
    }
    */
    /*
    public bool clicked, doubleClicked;
    [SerializeField] float delay_doubleClick = 1f, timePassedSinceLastClick;
    //[SerializeField] Button[] gameButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassedSinceLastClick += Time.deltaTime; //can't use delta time!
    }

    IEnumerator ResetClick(){
        yield return new WaitForEndOfFrame();
        clicked = false;
        doubleClicked = false;
    }

    public void OnPointerClick(PointerEventData eventData){
        clicked = true;
    }

    public void OnPointerDown(PointerEventData eventData){
        Debug.Log("Clicking");
        ///*
        if (timePassedSinceLastClick < delay_doubleClick){
            doubleClicked = true;
            Debug.Log("2x click!");
            StartCoroutine(ResetClick());
        }
        else
            timePassedSinceLastClick = 0;//
    }*/
}
