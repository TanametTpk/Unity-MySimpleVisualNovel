using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNFlowManager : MonoBehaviour
{
    public VNFlow entryRoute;
    public ConversationUI conversationUI;
    public CharacterUI characterUI;
    public ChoicesUIManager choicesUIManager;
    public VNFlow currentFlow;

    private void Start()
    {
        GoTo(entryRoute, true);
    }

    public void GoTo(VNFlow flow, bool isStart = false)
    {
        if (!isStart) currentFlow.End(this);
        currentFlow = flow;
        currentFlow.Go(this);
    }
}
