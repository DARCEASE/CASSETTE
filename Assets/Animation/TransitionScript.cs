using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour
{
    private string currentState;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransitionIn()
    {
        animator.enabled = true;
        ChangeAnimationState("SquareFadeIn");
    }

    public void TransitionOut()
    {
        animator.enabled = true;
        ChangeAnimationState("SquareFade");
    }

    //Change our current animation
    public void ChangeAnimationState(string newState) //Change title of currentState
    {
        if (currentState == newState) return;
        animator.Play(newState);
        currentState = newState;
    }
}
