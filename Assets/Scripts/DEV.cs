using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEV : MonoBehaviour{
	public AudioSource DevSource;
	void Start(){
		Time.timeScale = 1;
	}
	void Update(){
		if(Input.GetKeyDown("w")){
			Time.timeScale++;
			DevSource.pitch++;
		}
		if (Input.GetKeyDown("s")){
			Time.timeScale--;
			DevSource.pitch--;
		}
	}
}
