using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//PURPOSE: Allow you to click and drag UI windows
//USAGE: place this script on THE game manager? or the canvas itself
public class DragWindows : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField] private RectTransform dragRectTransform;
    float DragXPos, DragYPos;
    [SerializeField] private Canvas canvas;

    // Start is called before the first frame update
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        if (dragRectTransform == null)
        {
            dragRectTransform = transform.parent.GetComponent<RectTransform>();
        }
        if (canvas == null)
        {
            Transform testCanvasTransform = transform.parent;
            while (testCanvasTransform != null) //if empty, grab the nearest and most vaialbale canvas
            {
                
                canvas = testCanvasTransform.GetComponent<Canvas>();
                if (canvas != null)
                {
                    break;
                }
                testCanvasTransform = testCanvasTransform.parent;
            }
        }
    }
 
   
    void IDragHandler.OnDrag(PointerEventData eventData) // as youre draggging the mouse
    {

        DragXPos = (dragRectTransform.anchoredPosition.x + eventData.delta.x) / canvas.scaleFactor;
        DragYPos = (dragRectTransform.anchoredPosition.y + eventData.delta.y) / canvas.scaleFactor;

        if (DragXPos <= -200) //less than
        {
            DragXPos = -200;
        }
 
        if (DragXPos >= 430) //greater than
        {
            DragXPos = 430;
        }
 
        if (DragYPos >= 15) //less than
        {
            DragYPos = 15;
        }
 
        if (DragYPos <= -200)
        {
            DragYPos = -200;
        }

        dragRectTransform.anchoredPosition = new Vector2(DragXPos, DragYPos);
        //dragRectTransform.anchoredPosition = dragRectTransform.anchoredPosition + eventData.delta / canvas.scaleFactor; //grabs mvmt form previous mouse pos
        //dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; //grabs mvmt form previous mouse pos
        //windowpos.y = Mathf.Clamp(windowpos.y, 30, 15);
        Debug.Log("PlayerDraggingMouse");
    
    }
    public void OnPointerDown(PointerEventData eventData) // as you click and hold 
    {
        dragRectTransform.SetAsLastSibling();

        Debug.Log("everythingOnTop");
    }
}
