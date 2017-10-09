using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class restart : MonoBehaviour {
	float y;
	float temp;
	string path;
	int count = 3;
	public Text chances;
    // Use this for initialization
    void Start () {
		//count = 3;
		y = gameObject.transform.position.y;
		temp =y;
		
		chances.text = "Chances: "+PlayerPrefs.GetInt("chances",count).ToString();
		// PlayerPrefs.SetInt("chances",count);
		
	}
	
	// Update is called once per frame
	void Update () {
		y = gameObject.transform.position.y;

		if(y<temp*(-1)){
			count = PlayerPrefs.GetInt("chances",0);
			count--;
			PlayerPrefs.SetInt("chances",count);

			if(count==0){
				SceneManager.LoadScene(0);
				print("next");
				
				count=3;
				PlayerPrefs.SetInt("chances",count);
			}

			else{
				Scene scene = SceneManager.GetActiveScene();
			 	SceneManager.LoadScene(scene.name);
			}
			
			 
		}
	}
	

	public void resetChance(){
		PlayerPrefs.SetInt("chances",3);
	}
	
}