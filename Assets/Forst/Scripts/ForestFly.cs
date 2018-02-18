using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFly : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            print("I'm down!");
            Move();
        }
    }

    public void Move()
    {
        transform.position += Camera.main.transform.forward * Time.deltaTime * 10;
    }
}
