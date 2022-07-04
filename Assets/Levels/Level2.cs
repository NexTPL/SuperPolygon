using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardModeClip,DirectionClip;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 30;
		Score.LVLID = "L2";
		Score.LVLEND = 207;
		Polygon.ShrinkSpeed = 1.5f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(20/255f, 120/255f, 205/255f);
		BG.Color2 = new Color(20/255f, 205/255f, 140/255f);
		

		//Polygons//
		StartCoroutine(PolygonChange(0f, "4"));
		Invoke("Open", 0f);
		StartCoroutine(PolygonChange(29f, "6"));
		Invoke("Random", 42f);
		StartCoroutine(PolygonChange(71f, "6"));
		Invoke("Spiral", 71f);
		Invoke("Open", 71f);
		Invoke("SpiralDirectionChange", 85.5f);
		StartCoroutine(PolygonChange(94.9f, "4"));
		Invoke("Random", 97f);
		Invoke("Spiral", 97f);
		Invoke("Open", 97f);
		StartCoroutine(PolygonChange(108f, "5"));
		Invoke("Random", 108f);
		//HARD MODE//
		Invoke("Random", 120.5f);
		StartCoroutine(PolygonChange(132.5f, "6"));
		Invoke("Random", 144.5f);
		//StartCoroutine(PolygonChange(157f, "6R"));//
		StartCoroutine(PolygonChange(170.5f, "8"));
		Invoke("Random", 170.5f);
		Invoke("Spiral", 170.5f);
		Invoke("Open", 170.5f);
		Invoke("SpiralDirectionChange", 175.9f);
		Invoke("SpiralDirectionChange", 178f);
		Invoke("SpiralDirectionChange", 185f);
		Invoke("SpiralDirectionChange", 188f);
		Invoke("SpiralDirectionChange", 194f);
		Invoke("Open", 197.2f);
		Invoke("Spiral", 197.2f);
		StartCoroutine(PolygonChange(195.2f, "6"));
		

		//Direction//
		Invoke("Direction", 6.2f);
		Invoke("Direction", 30.5f);
		Invoke("Direction", 49f);
		Invoke("Direction", 61.1f);
		Invoke("Direction", 85.7f);
		Invoke("Direction", 110f);
		//HARD MODE//
		Invoke("Direction", 122.5f);
		Invoke("Direction", 137.8f);
		Invoke("Direction", 140.7f);
		Invoke("Direction", 146.5f);
		Invoke("Direction", 159f);
		Invoke("Direction", 185f);
		Invoke("Direction", 197.2f);
		Invoke("Direction", 203.2f);

		//ShrinkSpeed//
		StartCoroutine(ShrinkSpeed(30f, 1.62f));
		StartCoroutine(ShrinkSpeed(42.9f, 1.26f));
		StartCoroutine(ShrinkSpeed(61.1f, 1.38f));
		StartCoroutine(ShrinkSpeed(73f, 1.5f));
		StartCoroutine(ShrinkSpeed(85.7f, 1.62f));
		StartCoroutine(ShrinkSpeed(97f, 1.74f));
		StartCoroutine(ShrinkSpeed(110f, 1.5f));
		//HARD MODE//
		StartCoroutine(ShrinkSpeed(122.5f, 1.74f));
		StartCoroutine(ShrinkSpeed(134.5f, 1.38f));
		StartCoroutine(ShrinkSpeed(146.3f, 1.62f));
		StartCoroutine(ShrinkSpeed(172.8f, 1.38f));
		StartCoroutine(ShrinkSpeed(197.2f, 1.62f));
		StartCoroutine(ShrinkSpeed(207f, 1.26f));


		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(18.5f, 0.78f));
		StartCoroutine(SpawnRate(30f, 0.9f));
		StartCoroutine(SpawnRate(42.9f, 0.78f));
		StartCoroutine(SpawnRate(49f, 0.9f));
		StartCoroutine(SpawnRate(61.1f, 1.02f));
		StartCoroutine(SpiralSRate(71f, 0.25f));
		StartCoroutine(SpiralSRate(85.5f, 0.20f));
		StartCoroutine(SpawnRate(110f, 0.9f));
		//HARD MODE//
		StartCoroutine(SpawnRate(122.5f, 0.66f));
		StartCoroutine(SpawnRate(134.3f, 0.78f));
		StartCoroutine(SpawnRate(146.3f, 0.66f));
		StartCoroutine(SpiralSRate(185f, 0.15f));
		StartCoroutine(SpawnRate(197.2f, 0.78f));


		//CameraRotation//
		StartCoroutine(CameraRotation(18.3f, 50f));
		StartCoroutine(CameraRotation(42.9f, 10f));
		StartCoroutine(CameraRotation(49f, 30f));
		StartCoroutine(CameraRotation(61.1f, 50f));
		StartCoroutine(CameraRotation(70.3f, 30f));
		StartCoroutine(CameraRotation(73.3f, 70f));
		StartCoroutine(CameraRotation(97.9f, 90f));
		StartCoroutine(CameraRotation(108f, 70f));
		StartCoroutine(CameraRotation(109f, 50f));
		StartCoroutine(CameraRotation(110f, 30f));
		//HARD MODE//
		StartCoroutine(CameraRotation(122.5f, 50f));
		StartCoroutine(CameraRotation(128.5f, 70f));
		StartCoroutine(CameraRotation(134.5f, 10f));
		StartCoroutine(CameraRotation(146.5f, 30f));
		StartCoroutine(CameraRotation(159f, 50f));
		StartCoroutine(CameraRotation(169.5f, 10f));
		StartCoroutine(CameraRotation(172.4f, 110f));
		StartCoroutine(CameraRotation(185f, 130f));
		StartCoroutine(CameraRotation(197.2f, 90f));
		StartCoroutine(CameraRotation(208f, 30f));


		Invoke("End", 206);

		Invoke("HardMode",121.5f);
	}
	void End(){
		Spawner.Polygon = "END";
		Spawner.CanSpawn = false;
	}
	private void Spiral(){
		Spawner.isSpiral = !Spawner.isSpiral;
	}
	private void Random(){
		Spawner.isRandom = !Spawner.isRandom;
	}
	private void Open(){
		Spawner.isOpen = !Spawner.isOpen;
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
		AudioControllerSource.clip = DirectionClip;
		AudioControllerSource.Play();
		Direction();
	}
	private void HardMode(){
		AudioControllerSource.clip = HardModeClip;
		AudioControllerSource.Play();
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
}