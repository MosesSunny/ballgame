using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour {
       
        public float z;
    // Use this for initialization
    void Start () {
		
	}
    
    void FixedUpdate()
    {
        transform.Rotate(0,0,z);
    }
}
