using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialog", menuName = "VisualNovelTC/VNDialog")]
public class Dialog : ScriptableObject
{
    public CharacterInfo characterInfo;
    public EmotionalEnum emotionType;
    public string message;
    public bool isShowCharacterImage = true;
    public Color overlayColor = Color.white;
}
