﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour{
	private void OnTriggerEnter(Collider other){
		// Trigger detection
		print("HIT");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
