using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TransitionScript : MonoBehaviour
{
    private string currentState;

    private Animator animator;

    [SerializeField] float transitionTime;

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
    
    public void ToNextScene(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
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

    IEnumerator LoadLevel(int levelIndex){
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);

    }
}
