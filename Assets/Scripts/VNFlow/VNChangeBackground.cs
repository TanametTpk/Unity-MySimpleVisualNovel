using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new ChangeBackgroundFlow", menuName = "VisualNovelTC/Flow/ChangeBackgroundFlow")]
public class VNChangeBackground : VNFlow
{
    public BackgroundInfo backgroundInfo;
    public VNFlow nextFlow;
    
    public override void Go(VNFlowManager flowManager)
    {
        flowManager.conversationUI.SetBackground(backgroundInfo);
        flowManager.GoTo(nextFlow);
    }
}