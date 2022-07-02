using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : MonoBehaviour{
	public static float ShrinkSpeed;
	private bool isRotationEnabledOnStart;
	int _deg,_sides,rot,fixdirection;
	float a_deg = 0, offset;
	private float dir;

	void Start(){
		switch (Spawner.Polygon){
			case "4": { _deg = 90; _sides=4; break; }
			case "5": { _deg = 72; _sides=5; break; }
			case "6": { _deg = 60; _sides=6; break; }
			case "8": { _deg = 45; _sides=8; break; }
		}

		if(Spawner.isSpiral == true){
			if (Spawner.SpiralRandom == true){
				rot = Random.Range(0, _sides);
				while (rot == Spawner.LP1 || rot == Spawner.LP2){
					rot = Random.Range(0, _sides);
				}
				if(Spawner.LP1 != rot && rot != Spawner.LP2){
					transform.localRotation = Quaternion.Euler(0, 0, rot*_deg);
					Spawner.LP2 = Spawner.LP1;
					Spawner.LP1 = rot;
				}
			}
			if (Spawner.SpiralDirection == 1 && !Spawner.SpiralRandom){
				Spawner.S += 1;
				transform.localRotation = Quaternion.Euler(0, 0, Spawner.S*_deg);
			}
			if (Spawner.SpiralDirection == -1 && !Spawner.SpiralRandom){
				Spawner.S -= 1;
				transform.localRotation = Quaternion.Euler(0, 0, Spawner.S*_deg);
			}
		}
		else{
			offset = Random.Range(0, 8);
			isRotationEnabledOnStart = Spawner.RandomRotation;
			Invoke("Rotate", Spawner.SpawnRate - 0.25f);
		}
	}
	private void Rotate(){
		if (isRotationEnabledOnStart == true){
			Spawner.AR = Random.Range(0, 2);
			switch (Spawner.Polygon){
				case "4": { dir = 2; break; }
				case "4R": { dir = 2; break; }
				case "5": { dir = 1.6f; break; }
				case "5R": { dir = 1.6f; break; }
				case "6": { dir = 1.2f; break; }
				case "6R": { dir = 1.2f; break; }
				case "8": { dir = 1; break; }
				case "8R": { dir = 1; break; }
			}
			if (Spawner.AR == 1){
				dir = -dir;
				fixdirection = -1;
			}
			else{
				fixdirection = 1;
			}
		}
	}
	void FixedUpdate(){
		if (isRotationEnabledOnStart == true && Mathf.Abs(a_deg) < _deg){
			a_deg += dir;
		}
		if (Mathf.Abs(a_deg) > _deg){
			a_deg = _deg * fixdirection;
		}
		if(!Spawner.isSpiral) {transform.localRotation = Quaternion.Euler(0, 0, a_deg+(offset*_deg));}
		transform.localScale -= Vector3.one * (ShrinkSpeed * Time.deltaTime);
		if (transform.localScale.x < 0.15f){
			Destroy(gameObject);
		}
	}
}