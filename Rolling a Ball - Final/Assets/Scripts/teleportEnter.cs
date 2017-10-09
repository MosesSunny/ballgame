using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEnter : MonoBehaviour {
    private int count;
    private int temp;
    private int i;
    private GameObject[] teleport;


    // Use this for initialization
    void Start () {
        count = 0;
        temp = 0;
        i = 0;
    

        //tranform out of bound child exception handling
        try
        {
            while (true)
            {
                temp++;
                if (GameObject.Find(tag).transform.GetChild(temp).gameObject) count = temp;
            }
            
        }
        catch
        {
            teleport = new GameObject[count+1];
        }

        
        finally
        {
            while (i <= count)
            {
                teleport[i] = GameObject.Find(tag).transform.GetChild(i).gameObject;
                i++;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                other.gameObject.SetActive(false);
           //     other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                other.gameObject.transform.position = teleport[count].transform.position;
                other.gameObject.SetActive(true);

             //   other.gameObject.GetComponent<Rigidbody>().isKinematic = false;                
        }
    }
}
