using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour{
	public Text S,HS;
	static public string LVLID;
	static public int LVLEND;
	private float GameTime,StartTime;

	void Update(){
		if(GameTime < LVLEND){
			GameTime = Time.time - StartTime;
			S.text = (GameTime).ToString("F1");

			if (PlayerPrefs.GetFloat(LVLID) < GameTime){
				PlayerPrefs.SetFloat(LVLID, GameTime);
			}
		}
	}
	void Start(){
		StartTime = Time.time;
		HS.text = (PlayerPrefs.GetFloat(LVLID)).ToString("F1");
	}
}