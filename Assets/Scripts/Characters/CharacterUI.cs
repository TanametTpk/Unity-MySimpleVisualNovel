using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    public CharacterInfo character;
    public Image imageUI;
    
    public void SetCharacter(CharacterInfo characterInfo, EmotionalEnum emotion = EmotionalEnum.Idle)
    {
        character = characterInfo;
        if (!character.vnImages) return;
        var result = character.vnImages.GetSpriteFromEmotion(emotion);
        if (result == null)
        {
            imageUI.sprite = character.vnImages.GetSpriteFromEmotion(EmotionalEnum.Idle);
            return;
        }
        imageUI.sprite = result;
    }

    public void SetShowImage(bool isShow)
    {
        imageUI.gameObject.SetActive(isShow);
    }

    public void SetColor(Color color)
    {
        imageUI.color = color;
    }
}
