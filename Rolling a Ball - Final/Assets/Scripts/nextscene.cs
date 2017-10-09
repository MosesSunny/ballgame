using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextscene : MonoBehaviour {
    public string nextLevel;
    private GameObject Player;
    private timer t;
    private int score;
    private string Scorekey;
    public Text High_Score;
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
        t = Player.GetComponent<timer>();
        Scorekey = "score"+SceneManager.GetActiveScene().name;
        // PlayerPrefs.SetInt(Scorekey,0);//Reset Score
        getScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        	
        if (other.tag == "Player")
        {
             score = t.HighScore();
             if(score>PlayerPrefs.GetInt(Scorekey))
                   PlayerPrefs.SetInt(Scorekey,score);
             
             SceneManager.LoadScene(nextLevel);
            
        }
    }

    void getScore(){
        if(PlayerPrefs.GetInt(Scorekey)==3 || PlayerPrefs.GetInt(Scorekey)==2 || PlayerPrefs.GetInt(Scorekey)==0){
            High_Score.text = PlayerPrefs.GetInt(Scorekey).ToString();
        }
        else{
            High_Score.text = PlayerPrefs.GetInt(Scorekey).ToString();
        }
    }

    public void resetScore(){
        PlayerPrefs.SetInt("score"+SceneManager.GetActiveScene().name,0);
    }

    public void resetAllScore(){
        for(int i=1; i<=10; i++){
            PlayerPrefs.SetInt("scoreLevel"+i,0);
        }
    }
}