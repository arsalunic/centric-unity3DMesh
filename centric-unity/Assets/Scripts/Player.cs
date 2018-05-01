using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

//	float timeCounter = 0.0f;

	public int rotationSpeed = 100;

	//initialization
	void Start () {}

	public void ToggleRotation() {
		rotationSpeed = rotationSpeed * -1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
