using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ToNewspaperScene : MonoBehaviour
{
    [SerializeField] AudioController ac;
    //public Button SubmitButton;
    public GameObject articleObj;

    void Start()
    {
    //    SubmitButton = this.gameObject;
    }

    void Update()
    {
    }

    public void ActivateCoroutine(){
        StartCoroutine(LoadNewspaper(articleObj));

    }

    IEnumerator LoadNewspaper(GameObject article){
        ac.newspaperPrint_source.Play();
        yield return new WaitForSeconds(5);
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
