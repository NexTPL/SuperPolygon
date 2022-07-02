using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour{
	public static int Direction;
	public static float Rotation;
	void Awake() {
		Direction = 1;
	}
	void Update(){
		// Camera rotation script
		transform.Rotate(Vector3.forward, Time.deltaTime * Rotation * Direction);
	}
}
