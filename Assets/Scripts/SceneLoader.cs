using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}