using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour{
	public AudioSource HardPlayer;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 20;
		Score.LVLID = "L1";
		Score.LVLEND = 200;
		Polygon.ShrinkSpeed = 1.4f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(255/255f, 50/255f, 5/255f);
		BG.Color2 = new Color(255/255f, 130/255f, 10/255f);


		//Polygons//
		StartCoroutine(PolygonChange(30f, "5R"));
		StartCoroutine(PolygonChange(44f, "5"));
		StartCoroutine(PolygonChange(58f, "6R"));
		StartCoroutine(PolygonChange(71.5f, "6"));
		StartCoroutine(PolygonChange(81f, "4"));
		StartCoroutine(PolygonChange(95.5f, "4R"));
		//HARD MODE//
		StartCoroutine(PolygonChange(124f, "8R"));
		StartCoroutine(PolygonChange(138f, "8"));
		StartCoroutine(PolygonChange(152.6f, "5R"));
		StartCoroutine(PolygonChange(167f, "4R"));
		StartCoroutine(PolygonChange(181f, "6"));


		//ShrinkSpeed//
		StartCoroutine(ShrinkSpeed(7f, 1.45f));
		StartCoroutine(ShrinkSpeed(39.5f, 1.6f));
		StartCoroutine(ShrinkSpeed(44.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(61f, 1.6f));
		StartCoroutine(ShrinkSpeed(67f, 1.5f));
		StartCoroutine(ShrinkSpeed(83f, 1.3f));
		StartCoroutine(ShrinkSpeed(98f, 1.4f));
		StartCoroutine(ShrinkSpeed(112f, 1.5f));
		//HARD MODE//
		StartCoroutine(ShrinkSpeed(126f, 1.6f));
		StartCoroutine(ShrinkSpeed(141f, 1.7f));
		StartCoroutine(ShrinkSpeed(169f, 1.85f));
		StartCoroutine(ShrinkSpeed(183f, 1.5f));
		StartCoroutine(ShrinkSpeed(198f, 1f));


		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(32f, 1f));
		StartCoroutine(SpawnRate(32f, 0.95f));
		StartCoroutine(SpawnRate(61f, 0.9f));
		StartCoroutine(SpawnRate(68f, 1f));
		StartCoroutine(SpawnRate(83f, 0.95f));
		StartCoroutine(SpawnRate(98f, 1f));
		StartCoroutine(SpawnRate(112f, 1.1f));
		//HARD MODE//
		StartCoroutine(SpawnRate(123f, 1f));
		StartCoroutine(SpawnRate(140.3f, 0.9f));
		StartCoroutine(SpawnRate(154.6f, 0.8f));
		StartCoroutine(SpawnRate(169f, 0.7f));
		StartCoroutine(SpawnRate(183f, 1.1f));


		//CameraRotation//
		StartCoroutine(CameraRotation(14f, 35f));
		StartCoroutine(CameraRotation(28.5f, 5f));
		StartCoroutine(CameraRotation(32f, 40f));
		StartCoroutine(CameraRotation(39f, 50f));
		StartCoroutine(CameraRotation(39.3f, 60f));
		StartCoroutine(CameraRotation(44.5f, 30f));
		StartCoroutine(CameraRotation(46.2f, 50f));
		StartCoroutine(CameraRotation(60.7f, 60f));
		StartCoroutine(CameraRotation(67.8f, 35f));
		StartCoroutine(CameraRotation(82f, 20f));
		StartCoroutine(CameraRotation(90.7f, 5f));
		StartCoroutine(CameraRotation(97.8f, 35f));
		StartCoroutine(CameraRotation(112.4f, 50f));
		StartCoroutine(CameraRotation(119.2f, 35f));
		//HARD MODE//
		StartCoroutine(CameraRotation(124.4f, 20f));
		StartCoroutine(CameraRotation(126.4f, 70f));
		StartCoroutine(CameraRotation(138.9f, 50f));
		StartCoroutine(CameraRotation(140.5f, 80f));
		StartCoroutine(CameraRotation(147.8f, 90f));
		StartCoroutine(CameraRotation(153f, 50f));
		StartCoroutine(CameraRotation(154.9f, 80f));
		StartCoroutine(CameraRotation(182.2f, 95f));
		StartCoroutine(CameraRotation(183.2f, 35f));
		StartCoroutine(CameraRotation(198f, 20f));


		//Direction//
		Invoke("Direction", 32);
		Invoke("Direction", 46.2f);
		Invoke("Direction", 60.5f);
		Invoke("Direction", 74.7f);
		Invoke("Direction", 83.5f);
		Invoke("Direction", 97.8f);
		Invoke("Direction", 112f);
		//HARD MODE//
		Invoke("Direction", 126.3f);
		Invoke("Direction", 140.5f);
		Invoke("Direction", 147.7f);
		Invoke("Direction", 154.9f);
		Invoke("Direction", 161.7f);
		Invoke("Direction", 168.8f);
		Invoke("Direction", 176f);
		Invoke("Direction", 183.2f);


		Invoke("End", 196);

		StartCoroutine(HardMode(125.3f));
	}
	void End(){
		Spawner.Polygon = "END";
		Spawner.CanSpawn = false;
	}
	void HardMode(){
		HardPlayer.Play();
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
		Camera.current.GetComponent<AudioController>().DirectionAudio();
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
	IEnumerator HardMode(float time){
		yield return new WaitForSeconds(time);
		Camera.current.GetComponent<AudioController>().HardModeAudio();
	}
}