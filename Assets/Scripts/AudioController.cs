using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardMode,Direction;
	public void HardModeAudio() {
		AudioControllerSource.clip = HardMode;
		AudioControllerSource.Play();
	}
	public void DirectionAudio() {
		AudioControllerSource.clip = Direction;
		AudioControllerSource.Play();
	}
}
