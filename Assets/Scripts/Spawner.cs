﻿using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class Spawner : MonoBehaviour{
	public GameObject Polygon8F, Polygon4, Polygon5, Polygon6, Polygon8;
	public GameObject Polygon4W, Polygon5W, Polygon6W, Polygon8W;
	public static string Polygon;
	public static float SpawnRate, SpiralSpawnRate;
	public static int SpiralDirection;
	public static int WallPos = -1;
	public static bool SpiralRandom, RandomRotation, CanSpawn, isOpen, isSpiral, isRandom, addWall, remWall;
	public Animator CenterAnim, BGAnim;
	public static int S, AR, LP1, LP2;
	private bool _idk = true;
	private int BGShape;

	void Spawn(){
		// Check if polygon is not changing
		if (CanSpawn){
			if(addWall){
				switch (Polygon){
					case "4": { Instantiate(Polygon4W, Vector3.zero, Quaternion.identity); break; }
					case "5": { Instantiate(Polygon5W, Vector3.zero, Quaternion.identity); break; }
					case "6": { Instantiate(Polygon6W, Vector3.zero, Quaternion.identity); break; }
					case "8": { Instantiate(Polygon8W, Vector3.zero, Quaternion.identity); break; }
				}
				addWall = false;
			}
			else{
				// Spawn polygon
				switch (Polygon){
					case "4": { Instantiate(Polygon4, Vector3.zero, Quaternion.identity); break; }
					case "5": { Instantiate(Polygon5, Vector3.zero, Quaternion.identity); break; }
					case "6": { Instantiate(Polygon6, Vector3.zero, Quaternion.identity); break; }
					case "8": { Instantiate(Polygon8, Vector3.zero, Quaternion.identity); break; }
					case "END": { Instantiate(Polygon8F, Vector3.zero, Quaternion.identity); break; }
				}
			}
		}

		// Check polygon type and set delay
		if (isSpiral){
			Invoke("Spawn", SpiralSpawnRate);
		}
		else{
			Invoke("Spawn", SpawnRate);
		}
	}



	void Start(){
		Polygon = "4";
		CanSpawn = true;
		SpawnRate = 0.9f;
		Invoke("Spawn", 1.5f);
		SpiralSpawnRate = 0.2f;
		SpiralDirection = 1;
		SpiralRandom = false;
		isOpen = true;
		isSpiral = false;
		isRandom = false;
	}
	void FixedUpdate(){
		// Check if polygon is changing
		if (CanSpawn == false && _idk == true){
			_idk = false;
			Invoke("ResetSpawn", SpawnRate + 1);
			Invoke("ChangeBG", SpawnRate + 1f);
		}
	}
	// Reset
	void ResetSpawn(){
		CanSpawn = true;
		_idk = true;
	}
	// Change BG
	void ChangeBG(){
    switch (Spawner.Polygon){
			case "4": {BGShape=4; break; }
			case "5": {BGShape=5; break; }
			case "6": {BGShape=6; break; }
			case "8": {BGShape=8; break; }
			case "END": {BGShape=8; break; }
		}
		CenterAnim.SetInteger("Shape", BGShape);
		BGAnim.SetInteger("Shape", BGShape);
	}
}