using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new ChoiceFlow", menuName = "VisualNovelTC/Flow/ChoiceFlow")]
public class ChoiceFlow : VNFlow
{
    public List<VNChoice> choices;
    
    public override void Go(VNFlowManager flowManager)
    {
        flowManager.choicesUIManager.choices = choices;
        flowManager.choicesUIManager.CreateChoices();
        flowManager.choicesUIManager.gameObject.SetActive(true);
    }

    public override void End(VNFlowManager flowManager)
    {
        flowManager.choicesUIManager.gameObject.SetActive(false);
    }
}