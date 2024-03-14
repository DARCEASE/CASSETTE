using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//THIS IS WHERE THE ANIMATION WILL BE

public class ToNewspaperScene : MonoBehaviour
{
    [SerializeField] AudioController ac;
    [SerializeField] GameObject AnimationPanel;
    VideoPlayer vp;
    
    //public Button SubmitButton;
    public GameObject articleObj;

    void Start()
    {
    //    SubmitButton = this.gameObject;
        vp = AnimationPanel.GetComponent<VideoPlayer>();
    }

    void Update()
    {
    }

    public void ActivateCoroutine(){
        StartCoroutine(LoadNewspaper(articleObj));

    }

    IEnumerator LoadNewspaper(GameObject article){
        AnimationPanel.SetActive(true);
        vp.Play();
        ac.newspaperPrint_source.Play();
        yield return new WaitForSeconds(5);
        AnimationPanel.SetActive(false);
        article.SetActive(true);
    }

    /*[SerializeField] AudioController ac;
    public Button SubmitButton;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("NewspaperScene");
    }

    IEnumerator LoadNewspaper(string sceneName){
        ac.newspaperPrint_source.Play();
        yield return new WaitForSeconds(5);
    }*/
}
