using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {

	static List<GameObject> cubes;
	static string[] cubeNames = {
		"Cube 11",
		"Cube 12",
		"Cube 13",
		"Cube 14",
		"Cube 15",
		"Cube 21",
		"Cube 22",
		"Cube 23",
		"Cube 24",
		"Cube 25",
		"Cube 31",
		"Cube 32",
		"Cube 33",
		"Cube 34",
		"Cube 35",
		"Cube 41",
		"Cube 42",
		"Cube 43",
		"Cube 44",
		"Cube 45",
		"Cube 51",
		"Cube 52",
		"Cube 53",
		"Cube 54",
		"Cube 55",
	};

	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = getRandomMaterial().color;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Returns a random color from one of the four calming colors.
	Material getRandomMaterial() {
		switch (Random.Range (0, 3)) {
		case 0:
			return Resources.Load ("Light Green") as Material;
		case 1:
			return Resources.Load ("Dark Purple") as Material;
		case 2:
			return Resources.Load ("Dark Green") as Material;
		case 3:
			return Resources.Load ("Light Purple") as Material;
		}
		return null;
	}

	// Cycle through the materials in the same way.
	Material getNextMaterial() {
		if (GetComponent<Renderer> ().material.color == (Resources.Load ("Light Green") as Material).color) {
			return Resources.Load ("Light Purple") as Material;
		}
		else if (GetComponent<Renderer> ().material.color == (Resources.Load ("Light Purple") as Material).color) {
			return Resources.Load ("Dark Purple") as Material;
		}
		else if (GetComponent<Renderer> ().material.color == (Resources.Load ("Dark Purple") as Material).color) {
			return Resources.Load ("Dark Green") as Material;
		}
		else if (GetComponent<Renderer> ().material.color == (Resources.Load ("Dark Green") as Material).color) {
			return Resources.Load ("Light Green") as Material;
		}
		return null;
	}

	// Called when user clicks on the block.
	// 1) Change the color
	// 2) Check for puzzle completion
	// 3) If complete play sound and mix cubes
	public void onClick() {
		GetComponent<Renderer> ().material.color = getNextMaterial().color;
		bool allCubesMatch = true;
		for (int i = 0; i < cubeNames.Length - 1; i++) {
			if (GameObject.Find (cubeNames[i]).GetComponent<Renderer> ().material.color != GameObject.Find (cubeNames[i+1]).GetComponent<Renderer> ().material.color) {
				allCubesMatch = false;
			}
		}
		if (allCubesMatch) {
			print ("THEY ALL MATCH!!");
		}
	}
}
