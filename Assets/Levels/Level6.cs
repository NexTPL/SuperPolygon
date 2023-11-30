using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6 : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardModeClip,DirectionClip;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 30;
		Score.LVLID = "L6";
		Score.LVLEND = 234;
		Polygon.ShrinkSpeed = 1.75f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(68/255f, 86/255f, 159/255f);
		BG.Color2 = new Color(176/255f, 65/255f, 181/255f);
		BG.Speed = 0.2f;


		// Saneron ;) //
		StartCoroutine(PolygonChange(0f, "4"));
			StartCoroutine(PolygonChange(14f, "5"));
		StartCoroutine(PolygonChange(20f, "6"));
		StartCoroutine(PolygonChange(26f, "8"));

		StartCoroutine(Wall(6f, "add", 0));
		StartCoroutine(Wall(12f, "rem"));
		StartCoroutine(Wall(18f, "add", 0));
		StartCoroutine(Wall(24f, "rem"));
			StartCoroutine(Wall(30f, "add", 0));
		StartCoroutine(Wall(36f, "rem"));


		Invoke("Open", 5f);
		Invoke("Random", 5f);
		// Invoke("Spiral", 30f);


		Invoke("End", 232f);
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
	IEnumerator Wall(float time, string method, int pos = 0){
		yield return new WaitForSeconds(time);
		switch(method){
			case "add": {Spawner.addWall = true; Spawner.WallPos = pos; break;}
			case "rem": {Spawner.remWall = true; break;}
			default: {break;}
		}
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