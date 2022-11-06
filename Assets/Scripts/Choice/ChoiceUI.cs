using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceUI : MonoBehaviour
{
    public TMP_Text textUI;
    public Button choiceButton;
    public VNFlowManager flowManager;
    public VNFlow flow;

    private void Start()
    {
        flowManager = FindObjectOfType<VNFlowManager>();
        choiceButton.onClick.AddListener(GoToFlow);
    }

    private void OnDestroy()
    {
        choiceButton.onClick.RemoveListener(GoToFlow);
    }

    private void GoToFlow()
    {
        flowManager.GoTo(flow);
    }

    public void SetText(string text)
    {
        textUI.text = text;
    }
}
