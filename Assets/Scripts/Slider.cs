using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class Slider : MonoBehaviour{
	public AudioMixer mixer;
	public UnityEngine.UI.Slider Level;

	public void SetLevel(float sliderValue){
		mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 25);
	}
	public void Save(){
		PlayerPrefs.SetFloat("SliderLevel", Level.value);
	}
	void Start(){
		Level.value = PlayerPrefs.GetFloat("SliderLevel");
	}
}