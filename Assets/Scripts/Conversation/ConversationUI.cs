using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationUI : MonoBehaviour
{
    public DialogUI dialogUI;
    public Conversation conversation;
    public VNFlowManager flowManager;
    public VNFlow nextFlow;
    public BackgroundInfo backgroundInfo;
    public Image backgroundImage;
    [SerializeField] private int currentIndexConversation;
    
    void Start()
    {
        flowManager = FindObjectOfType<VNFlowManager>();
        ShowCurrentConversation();
    }

    public void SetBackground(BackgroundInfo newBackground)
    {
        backgroundInfo = newBackground;
        backgroundImage.sprite = newBackground.backgroundImage;
    }

    private bool IsConversationEnd()
    {
        if (!conversation) return false;
        return conversation.dialogs.Count <= currentIndexConversation;
    }

    public void ShowCurrentConversation()
    {
        if (!conversation) return;
        dialogUI.SetDialog(conversation.dialogs[currentIndexConversation]);
    }

    public void NextConversation()
    {
        if (!conversation) return;
        currentIndexConversation++;
        
        if (IsConversationEnd())
        {
            flowManager.GoTo(nextFlow);
            return;
        }
        
        dialogUI.SetDialog(conversation.dialogs[currentIndexConversation]);
    }

    public void Reset()
    {
        currentIndexConversation = 0;
    }
}
