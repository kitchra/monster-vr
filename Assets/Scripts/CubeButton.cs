using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeButton : MonoBehaviour {

    public Transform transform;
    public float frequency = 1f;    //movement speed
    public float amplitude = 1f;    //movement amount
    Quaternion startRot;
    float elapsedTime = 0f;

    void Start() {
        startRot = transform.rotation;

    }

        // Update is called once per frame
    void Update () {
        elapsedTime += Time.deltaTime * Time.timeScale * 1f;
        transform.Rotate(new Vector3(1,0,0) * Mathf.Sin(elapsedTime) * amplitude, frequency * Time.deltaTime);
    }

    public void changeColor()
    {
        Color currColor = gameObject.GetComponent<Renderer>().material.color;
        currColor.a = currColor.a - 0.2f;
        gameObject.GetComponent<Renderer>().material.color = currColor;
    }
}
