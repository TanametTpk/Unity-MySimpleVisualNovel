using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character Images Set", menuName = "VisualNovelTC/VNCharacterImages")]
public class VNCharacterImages : ScriptableObject
{
    public List<EmotionalImage> EmotionalImages;
    public EmotionalEnum defaultEmotionType;

    public Sprite GetSpriteFromEmotion(EmotionalEnum emotionType)
    {
        var foundImage = EmotionalImages.FirstOrDefault(emoImage => emoImage.emotionType == emotionType);
        if (foundImage != null) return foundImage.Image;
        
        foundImage = EmotionalImages.FirstOrDefault(emoImage => emoImage.emotionType == defaultEmotionType);
        return foundImage != null ? foundImage.Image : null;
    }
}

[Serializable]
public class EmotionalImage
{
    public EmotionalEnum emotionType;
    public Sprite Image;
}