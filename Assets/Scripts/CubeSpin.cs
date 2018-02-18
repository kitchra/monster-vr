using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpin : MonoBehaviour {

	GameObject selectedCube;
	GameObject oldSelectedCube;
	bool isSelected;

	// Use this for initialization
	void Start () {
		isSelected = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		RaycastHit hit = new RaycastHit ();
		Ray ray = new Ray (transform.position, Camera.main.transform.forward);
		//Debug.DrawRay(transform.position, Camera.main.transform.forward, Color.green);
		if (Physics.Raycast (ray, out hit) && hit.collider.tag == "Cube") {
			selectedCube = hit.collider.gameObject;
			if (!isSelected) {
				oldSelectedCube = selectedCube;
				hit.collider.gameObject.transform.Translate (0, 0, -0.35f, Space.World);
				isSelected = true;
			}
			if (oldSelectedCube != selectedCube) {
				oldSelectedCube.transform.Translate (0, 0, 0.35f, Space.World);
				hit.collider.gameObject.transform.Translate (0, 0, -0.35f, Space.World);
				oldSelectedCube = selectedCube;
				isSelected = true;
			}
		} else {
			if (isSelected) {
				// Move the object back.
				oldSelectedCube.transform.Translate (0, 0, 0.35f, Space.World);
				isSelected = false;
			}
		}
	}
}
