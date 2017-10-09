using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolution : MonoBehaviour {
    
    public float speed = 0;
    public float radius = 5;
    private float originx;
    private float originz;
    public float start_degree;
    private float rad;
    private Vector3 worldspace;
    public string center;
    public int direction;
	// Use this for initialization
	void Start () {
        worldspace = GameObject.Find(center).transform.position;
        originx = worldspace.x;
        originz = worldspace.z;
        rad = start_degree * Mathf.Deg2Rad;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rad += direction*0.02f * speed;
        float x = Mathf.Sin(rad) * radius + originx;
        float z = Mathf.Cos(rad) * radius + originz;
        transform.position = new Vector3(x, worldspace.y, z);
    }

    
}
