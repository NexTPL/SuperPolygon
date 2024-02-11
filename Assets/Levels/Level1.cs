using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardModeClip,DirectionClip;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 20;
		Score.LVLID = "L1";
		Score.LVLEND = 198;
		Polygon.ShrinkSpeed = 1.4f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(200/255f, 51/255f, 0/255f);
		BG.Color2 = new Color(255/255f, 149/255f, 0/255f);
		BG.Speed = 0.001f;

		//BG Speed//
		StartCoroutine(BGSpeed(14.3f, 0.3f));
		StartCoroutine(BGSpeed(28.5f, 0.2f));
		StartCoroutine(BGSpeed(32f, 1f));
		StartCoroutine(BGSpeed(33f, 0.25f));
		StartCoroutine(BGSpeed(83.5f, 0.25f));
		StartCoroutine(BGSpeed(111f, 4f));
		StartCoroutine(BGSpeed(112.2f, 0.25f));
		StartCoroutine(BGSpeed(140.5f, 0.5f));
		StartCoroutine(BGSpeed(155f, 0.75f));
		StartCoroutine(BGSpeed(187.5f, 0.5f));

		//BG Color//
		StartCoroutine(Color1(28.5f, 20, 0, 0));
		StartCoroutine(Color1(33f, 200, 51, 0));

		StartCoroutine(Color1(46f, 255, 82, 0));
		StartCoroutine(Color2(46f, 255, 142, 0));

		StartCoroutine(Color1(82f, 158, 0, 0));
		StartCoroutine(Color2(82f, 168, 98, 0));

		StartCoroutine(Color1(112.2f, 200, 0, 0));
		StartCoroutine(Color2(112.2f, 200, 116, 0));

		StartCoroutine(Color1(126.5f, 200, 5, 5));
		StartCoroutine(Color2(126.5f, 200, 106, 30));

		StartCoroutine(Color1(140.5f, 220, 10, 10));
		StartCoroutine(Color2(140.5f, 180, 10, 10));

		StartCoroutine(Color1(183.5f, 200, 51, 0));
		StartCoroutine(Color2(183.5f, 209, 122, 0));




		//Polygons//
		Invoke("Open", 0f);
		StartCoroutine(PolygonChange(30f, "5"));
		Invoke("Random", 30f);
		Invoke("Random", 44f);
		StartCoroutine(PolygonChange(58.5f, "6"));
		Invoke("Random", 58f);
		Invoke("Random", 71.5f);
		StartCoroutine(PolygonChange(81f, "4"));
		Invoke("Random", 96.5f);
		StartCoroutine(PolygonChange(96f, "5"));
		StartCoroutine(PolygonChange(110f, "6"));
		//HARD MODE//
		StartCoroutine(PolygonChange(124f, "8"));
		Invoke("Random", 138f);
		StartCoroutine(PolygonChange(138.25f, "8"));
		Invoke("Random", 154f);
		StartCoroutine(PolygonChange(152f, "5"));
		StartCoroutine(PolygonChange(167f, "4"));
		Invoke("Random", 182f);
		StartCoroutine(PolygonChange(181.5f, "6"));


		//ShrinkSpeed//
		StartCoroutine(ShrinkSpeed(7f, 1.45f));
		StartCoroutine(ShrinkSpeed(14.3f, 1.53f));
		StartCoroutine(ShrinkSpeed(39.5f, 1.6f));
		StartCoroutine(ShrinkSpeed(44.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(61f, 1.6f));
		StartCoroutine(ShrinkSpeed(67f, 1.5f));
		StartCoroutine(ShrinkSpeed(83f, 1.3f));
		StartCoroutine(ShrinkSpeed(98f, 1.4f));
		StartCoroutine(ShrinkSpeed(112f, 1.5f));
		//HARD MODE//
		StartCoroutine(ShrinkSpeed(126f, 1.7f));
		StartCoroutine(ShrinkSpeed(141f, 1.3f));
		StartCoroutine(ShrinkSpeed(169f, 1.7f));
		StartCoroutine(ShrinkSpeed(183f, 1.6f));
		StartCoroutine(ShrinkSpeed(197f, 1f));


		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(0f, 1.1f));
		StartCoroutine(SpawnRate(26f, 4f));
		StartCoroutine(SpawnRate(30f, 0.95f));
		StartCoroutine(SpawnRate(41.5f, 4f));
		StartCoroutine(SpawnRate(45.5f, 0.95f));
		StartCoroutine(SpawnRate(61f, 0.9f));
		StartCoroutine(SpawnRate(70f, 2f));
		StartCoroutine(SpawnRate(72f, 0.75f));
		StartCoroutine(SpawnRate(73.5f, 0.9f));
		StartCoroutine(SpawnRate(83f, 0.95f));
		StartCoroutine(SpawnRate(98f, 1f));
		StartCoroutine(SpawnRate(112f, 1.1f));
		//HARD MODE//
		StartCoroutine(SpawnRate(123f, 1.2f));
		StartCoroutine(SpawnRate(140.3f, 1.5f));
		StartCoroutine(SpawnRate(154.6f, 0.8f));
		StartCoroutine(SpawnRate(169f, 0.7f));
		StartCoroutine(SpawnRate(183f, 1.1f));
		StartCoroutine(SpawnRate(197f, 2f));


		//CameraRotation//
		StartCoroutine(CameraRotation(14.3f, 35f));
		StartCoroutine(CameraRotation(28.5f, 5f));
		StartCoroutine(CameraRotation(32f, 40f));
		StartCoroutine(CameraRotation(39f, 50f));
		StartCoroutine(CameraRotation(39.3f, 60f));
		StartCoroutine(CameraRotation(44.5f, 30f));
		StartCoroutine(CameraRotation(46.2f, 50f));

		StartCoroutine(CameraRotation(58f, 60f));
		StartCoroutine(CameraRotation(58.2f, 70f));
		StartCoroutine(CameraRotation(58.4f, 80f));
		StartCoroutine(CameraRotation(58.6f, 90f));
		StartCoroutine(CameraRotation(58.8f, 100f));
		StartCoroutine(CameraRotation(59f, 110f));

		StartCoroutine(CameraRotation(60.7f, 70f));
		StartCoroutine(CameraRotation(67.8f, 45f));

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


		Invoke("End", 195);

		Invoke("HardMode",125.3f);
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
	IEnumerator BGSpeed(float time, float speed){
		yield return new WaitForSeconds(time);
		BG.Speed = speed;
	}
}