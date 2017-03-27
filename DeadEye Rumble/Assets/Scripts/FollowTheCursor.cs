using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheCursor : MonoBehaviour {

	public float speed = 100.0f;
	private Vector3 destination;

	// Use this for initialization
	void Start () {
		destination = transform.position;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		//Change cursor position to position of mouse pressed
		if (Input.mousePresent) {
			float distance = transform.position.z - Camera.main.transform.position.z;

			destination = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);

			destination = Camera.main.ScreenToWorldPoint (destination);
			//transform.position = destination;
		}

		//transform.position = Vector3.Lerp (transform.position, destination, speed * Time.deltaTime);
		transform.position = destination;


	}
}
