using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	public float speed=5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Rightward Movement
		if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow)){
			float x = transform.position.x - (0.01f * speed);
			transform.position = new Vector3(x, transform.position.y, transform.position.z);

			//rotating along z
			transform.Rotate(0,0,1*speed,Space.World);
		}

		//Leftward Movement
		if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow)){
			float x = transform.position.x + (0.01f * speed);
			transform.position = new Vector3(x, transform.position.y, transform.position.z);

			//rotating along -z
			transform.Rotate(0,0,-1*speed,Space.World);
		}

		//Upward Movement
		if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow)){
			float z = transform.position.z - (0.01f * speed);
			transform.position = new Vector3(transform.position.x, transform.position.y, z);

			//rotating along -x
			transform.Rotate(-1*speed,0,0,Space.World);
		}

		//Downward Movement
		if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow)){
			float z = transform.position.z + (0.01f * speed);
			transform.position = new Vector3(transform.position.x, transform.position.y, z);

			//rotating along x
			transform.Rotate(1*speed,0,0,Space.World);
		}
	}

	public void adjustSpeed(float newSpeed){
		speed = newSpeed;
	}
}
