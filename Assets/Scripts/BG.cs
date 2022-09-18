using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour{
	public Material[] Materials, MatArray;
	public static Color Color1, Color2;
	Color lerpedColor;
	public Material Mat1, Mat2, Mat3;
	public static float Speed;
	public Renderer Renderer;
	private bool isT1;

	private void Start(){
		isT1 = true;
	}
	private void FixedUpdate(){
		lerpedColor = Color.Lerp(Color1, Color2, Mathf.PingPong(Time.time * Speed, 1));
		Mat1.SetColor("_EmissionColor", lerpedColor);
		Mat1.SetColor("_Color", lerpedColor);
		Mat2.SetColor("_EmissionColor", lerpedColor);
		Mat2.SetColor("_Color", lerpedColor);
		Mat3.SetColor("_EmissionColor", lerpedColor);
		Mat3.SetColor("_Color", lerpedColor);
	}
	private void OnTriggerEnter(Collider other){
		if(isT1){
			MatArray[0] = Materials[1];
			MatArray[1] = Materials[0];
			isT1 = false;
		}
		else{
			MatArray[0] = Materials[0];
			MatArray[1] = Materials[1];
			isT1 = true;
		}
		Renderer.materials = MatArray;
	}
}
