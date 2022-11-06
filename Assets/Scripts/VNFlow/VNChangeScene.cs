using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "new ChangeSceneFlow", menuName = "VisualNovelTC/Flow/ChangeSceneFlow")]
public class VNChangeScene : VNFlow
{
    public string sceneName;
    
    public override void Go(VNFlowManager flowManager)
    {
        SceneManager.LoadScene(sceneName);
    }
}