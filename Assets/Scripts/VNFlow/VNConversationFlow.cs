using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new ConversationFlow", menuName = "VisualNovelTC/Flow/ConversationFlow")]
public class VNConversationFlow : VNFlow
{
    public Conversation conversation;
    public VNFlow nextFlow;
    
    public override void Go(VNFlowManager flowManager)
    {
        flowManager.conversationUI.Reset();
        flowManager.conversationUI.conversation = conversation;
        flowManager.conversationUI.nextFlow = nextFlow;
        flowManager.conversationUI.ShowCurrentConversation();
    }

    public override void End(VNFlowManager flowManager)
    {
        flowManager.conversationUI.conversation = null;
        flowManager.conversationUI.Reset();
    }
}
