using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour{
	public GameObject b2,b3,b4,b5,b6,b7;
	void Start(){
		if(PlayerPrefs.GetFloat("L1") >= 126){
			b2.SetActive(true);
		}
		else{
			b2.SetActive(false);
		}
		if (PlayerPrefs.GetFloat("L2") >= 122){
			b3.SetActive(true);
		}
		else{
			b3.SetActive(false);
		}
		if (PlayerPrefs.GetFloat("L3") >= 126){
			b4.SetActive(true);
		}
		else{
			b4.SetActive(false);
		}
		if (PlayerPrefs.GetFloat("L4") >= 120){
			b5.SetActive(true);
		}
		else{
			b5.SetActive(false);
		}
		if (PlayerPrefs.GetFloat("L1") == 200 && PlayerPrefs.GetFloat("L2") == 207 && PlayerPrefs.GetFloat("L3") == 198 && PlayerPrefs.GetFloat("L4") == 188 && PlayerPrefs.GetFloat("L5") == 230){
			b6.SetActive(true);
		}
		else{
			b6.SetActive(false);
		}

		if (PlayerPrefs.GetFloat("L6") > 0){
			b7.SetActive(true);
		}
		else{
			b7.SetActive(false);
		}
	}
}