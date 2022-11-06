using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Character", menuName = "VisualNovelTC/CharacterInfo")]
public class CharacterInfo : ScriptableObject
{
    public new string name;
    public string description;
    public VNCharacterImages vnImages;
}
