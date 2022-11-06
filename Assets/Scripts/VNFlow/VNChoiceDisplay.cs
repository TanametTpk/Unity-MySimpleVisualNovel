using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNChoiceDisplay : IVNRoute
{

    public string GetID()
    {
        return "Choice";
    }
    
    public void Go(VNFlowManager flowManager)
    {
        // set choice
        // string[] authors = { "Mike Gold", "Don Box",    
        //     "Sundar Lal", "Neel Beniwal" }; 
        // flowManager.choicesUIManager.choices = new List<string>(authors);
        // flowManager.choicesUIManager.CreateChoices();
    }
}
