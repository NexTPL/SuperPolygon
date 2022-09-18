using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardModeClip,DirectionClip;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 180;
		Score.LVLID = "L7";
		Score.LVLEND = 163;
		Polygon.ShrinkSpeed = 2.5f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(239/255f, 239/255f, 239/255f);
		BG.Color2 = new Color(209/255f, 209/255f, 209/255f);

		// Saneron ;) //

		StartCoroutine(PolygonChange(0f, "4R"));
		StartCoroutine(PolygonChange(9f, "5"));
		StartCoroutine(PolygonChange(20f, "8R"));
		StartCoroutine(PolygonChange(41f, "6"));
		StartCoroutine(PolygonChange(43f, "6S"));
		Invoke("SpiralRandomChange", 42f);

		Invoke("Direction", 5.5f);
		Invoke("Direction", 11f);
		Invoke("Direction", 16.5f);
		Invoke("Direction", 22f);
		Invoke("Direction", 33f);


		StartCoroutine(ShrinkSpeed(22f, 2.4f));
		StartCoroutine(ShrinkSpeed(33f, 2.5f));


		StartCoroutine(SpawnRate(0f, 0.7f));
		StartCoroutine(SpawnRate(22f, 0.6f));


		StartCoroutine(CameraRotation(27.4f, 180f));
		StartCoroutine(CameraRotation(29.4f, 210f));
		StartCoroutine(CameraRotation(30.0f, 240f));
		StartCoroutine(CameraRotation(30.6f, 270f));
		StartCoroutine(CameraRotation(33f, 150f));
		StartCoroutine(CameraRotation(38.6f, 180f));
		StartCoroutine(CameraRotation(41.4f, 210f));
		StartCoroutine(CameraRotation(42.0f, 240f));
		StartCoroutine(CameraRotation(42.6f, 270f));
		StartCoroutine(CameraRotation(44f, 150f));


	}
	void End(){
		Spawner.Polygon = "END";
		Spawner.CanSpawn = false;
	}
	private void RandomRotation(){
		Spawner.RandomRotation = !Spawner.RandomRotation;
	}
	private void SpiralDirectionChange(){
		Spawner.SpiralDirection = -Spawner.SpiralDirection;
	}
	private void SpiralRandomChange(){
		Spawner.SpiralRandom = !Spawner.SpiralRandom;
	}
	private void Direction(){
		GameCamera.Direction = -GameCamera.Direction;
	}
	private void PlayerDirection(){
		Player.Direction = -Player.Direction;
		Direction();
	}
	IEnumerator CameraRotation(float time, float speed){
		yield return new WaitForSeconds(time);
		GameCamera.Rotation = speed;
	}
	IEnumerator ShrinkSpeed(float time, float speed){
		yield return new WaitForSeconds(time);
		Polygon.ShrinkSpeed = speed;
	}
	IEnumerator SpawnRate(float time, float speed){
		yield return new WaitForSeconds(time);
		Spawner.SpawnRate = speed;
	}
	IEnumerator SpiralSRate(float time, float speed){
		yield return new WaitForSeconds(time);
		Spawner.SpiralSpawnRate = speed;
	}
	IEnumerator PolygonChange(float time, string polygon){
		yield return new WaitForSeconds(time);
		Spawner.Polygon = polygon;
		Spawner.CanSpawn = false;
	}
	IEnumerator Color1(float time, int R, int G, int B){
		yield return new WaitForSeconds(time);
		BG.Color1 = new Color(R / 255f, G / 255f, B / 255f);
	}
	IEnumerator Color2(float time, int R, int G, int B){
		yield return new WaitForSeconds(time);
		BG.Color2 = new Color(R / 255f, G / 255f, B / 255f);
	}
	IEnumerator BGSpeed(float time, float speed){
		yield return new WaitForSeconds(time);
		BG.Speed = speed;
	}
}