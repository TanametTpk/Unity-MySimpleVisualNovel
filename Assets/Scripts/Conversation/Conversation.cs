using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName = "VisualNovelTC/VNConversation")]
public class Conversation : ScriptableObject
{
    public List<Dialog> dialogs;
}
