using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogUI : MonoBehaviour
{
    public Dialog dialog;
    public TMP_Text nameUI;
    public TMP_Text messageUI;
    public CharacterUI CharacterUI;

    public void SetDialog(Dialog newDialog)
    {
        dialog = newDialog;
        messageUI.text = dialog.message;
        nameUI.text = dialog.characterInfo.name;
        CharacterUI.SetCharacter(dialog.characterInfo, dialog.emotionType);
        CharacterUI.SetShowImage(newDialog.isShowCharacterImage);
        CharacterUI.SetColor(newDialog.overlayColor);
    }
}
