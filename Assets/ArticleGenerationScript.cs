using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArticleGenerationScript : MonoBehaviour
{

    //Prototyping a system where depending on the player's choices, each sentence would change
    // Estimating about 4-5 sentences per para (about 12-15 list boxes)
    //Will store options in an array and will piece them together here so the ROTDORE script can
    // access it.
    // 3 options to choose from = 3 different sentences per fill-in



    [SerializeField] string ParaOneSent_One, ParaOneSent_Two, ParaOneSent_Three, ParaOneSent_Four, ParaOneSent_Five;
    string ParaTwoSent_One, ParaTwoSent_Two, ParaTwoSent_Three, ParaTwoSent_Four, ParaTwoSent_Five;
    string ParaThreeSent_One, ParaThreeSent_Two, ParaThreeSent_Three, ParaThreeSent_Four, ParaThreeSent_Five;
    string ParaFourSent_One, ParaFourSent_Two, ParaFourSent_Three, ParaFourSent_Four, ParaFourSent_Five;
    string ParaFiveSent_One, ParaFiveSent_Two, ParaFiveSent_Three, ParaFiveSent_Four, ParaFiveSent_Five; 
    
    [TextArea] //WILL HAVE MULTIPLE BOXES FOR DIFFERENT PARAGRAPH OPTIONS.

    [SerializeField] string[] newspaperHeadlines, ParaOneSentences, ParaTwoSentences, ParaThreeSentences, ParaFourSentences, ParaFiveSentences;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
