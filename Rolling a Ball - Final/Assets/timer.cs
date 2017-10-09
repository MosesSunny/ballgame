using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text min;
	public Text sec;
	public Text score;
	private int count;
	private int second;
	private int minute;
	private int tempSec;
	public int scorenum;

	public int score2_min;
	public int score2_max;
	public int score1_min;
	public int score1_max;
	public int score0_min;

	// Use this for initialization
	void Start () {
		count =0;
		second =0;
		minute =0;
		tempSec =0;
		scorenum =3;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		TimerSet();
		HighScore();
	}

	void TimerSet(){
		if(second==59){
			second =-1;
		}

		if(count==59){
			count=0;
			
			if(second==-1){
				minute++;
				if(minute<10){
					min.text = "0"+minute;
				}
				else{
					min.text = minute.ToString();					
				}
			}

			second++;

			if(second<10){
				sec.text = "0"+second;
			}
			else{
				sec.text = second.ToString();
			}	

			tempSec++;
		}
		count++;
	}

	
	public int HighScore(){
		if(tempSec>=score2_min && tempSec<=score2_max){
			scorenum=2;
			score.text = scorenum.ToString();
		}
		else if(tempSec>=score1_min && tempSec<=score1_max){
			scorenum=1;
			score.text = scorenum.ToString();
		}
		else if(tempSec>=score0_min){
			scorenum=0;
			score.text = scorenum.ToString();
		}
		return scorenum;
	}

}
