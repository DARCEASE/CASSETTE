using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SideArticleScript : MonoBehaviour
{
    //For side articles across the stories
    //MILESTONE 3: Novak only

    [SerializeField] string[] SideArticles; //Text will change for the SA
    [SerializeField] TMP_Text sideArticleText;
    public int sideArt1, sideArt2, sideArt3, sideArt4, sideArt5; //Jim Q'd, Michael assaulted, Abundantia Success, Evergreen Park, DADT
    
    void Start()
    {
        sideArt5 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //sideArticleText.text = textString;
    }

    public string ROTDORESAS(){
        //Compares the values to each other and prints out the leading one

        if (sideArt1 > sideArt2 && sideArt1 > sideArt3 && sideArt1 > sideArt4  && sideArt4 > sideArt5){
            sideArticleText.text = SideArticles[0];
        } else if (sideArt2 > sideArt1 && sideArt2 > sideArt3 && sideArt2 > sideArt4  && sideArt2 > sideArt5){
            sideArticleText.text = SideArticles[1];
        } else if (sideArt3 > sideArt1 && sideArt3 > sideArt2 && sideArt3 > sideArt4  && sideArt3 > sideArt5){
            sideArticleText.text = SideArticles[2];
        } else if (sideArt4 > sideArt1 && sideArt4 > sideArt2 && sideArt4 > sideArt3  && sideArt4 > sideArt5){
            sideArticleText.text = SideArticles[3];
        }
        else{
            sideArticleText.text = SideArticles[4];
        }

        return sideArticleText.text;
    }
}
