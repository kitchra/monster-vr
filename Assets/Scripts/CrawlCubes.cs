using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlCubes : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.one, 30 * Time.deltaTime);
    }
}
