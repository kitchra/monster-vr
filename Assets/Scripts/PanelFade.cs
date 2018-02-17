using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelFade : MonoBehaviour
{

    public Material m;
    public float _colorSpeed = 0.01f;
    private Color c;
    private bool start = false;

    void Update()
    {
        if (start)
        {
            if (c.a < 1.0f)
                c.a = c.a + _colorSpeed;
            m.color = c;
        }
    }
    public void Fade()
    {
        c = m.color;
        c.a = 0.0f;
        start = true;
    }
}