using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesUIManager : MonoBehaviour
{
    public List<VNChoice> choices;
    public GameObject choicesUIContainer;
    public ChoiceUI choicePrefab;

    public void CreateChoices()
    {
        RemoveAllChoices();
        foreach (var choice in choices)
        {
            CreateChoice(choice);
        }
    }

    private void CreateChoice(VNChoice currentChoice)
    {
        var choice = Instantiate(choicePrefab, choicesUIContainer.transform);
        choice.SetText(currentChoice.choiceTxt);
        choice.flow = currentChoice.flowAction;
    }

    private void RemoveAllChoices()
    {
        foreach (Transform child in choicesUIContainer.transform) {
            Destroy(child.gameObject);
        }
    }
}
