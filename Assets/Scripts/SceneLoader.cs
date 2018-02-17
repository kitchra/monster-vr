using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public void loadScene(string sceneName)
    {
        PanelFade pf = GameObject.Find("PanelFadeObject").GetComponent<PanelFade>();
        pf.loadLevel(sceneName);
    }
}