using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour{
	public AudioSource HardPlayer;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 25;
		Score.LVLID = "L3";
		Score.LVLEND = 198;
		Polygon.ShrinkSpeed = 1.6f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(106/255f, 205/255f, 30/255f);
		BG.Color2 = new Color(205/255f, 147/255f, 20/255f);
		

		// Saneron ;) //

		//Polygons//

		StartCoroutine(PolygonChange(0f, "5"));
		StartCoroutine(PolygonChange(16f, "5R"));
		StartCoroutine(PolygonChange(29f, "4"));
		StartCoroutine(PolygonChange(42.5f, "6R"));
		StartCoroutine(PolygonChange(59.5f, "8S"));
		Invoke("SpiralRandomChange", 61f);
		StartCoroutine(PolygonChange(72.3f, "6S"));
		Invoke("SpiralRandomChange", 87.5f);
		Invoke("SpiralDirectionChange", 91f);
		Invoke("SpiralDirectionChange", 94.5f);
		Invoke("SpiralDirectionChange", 97.8f);
		StartCoroutine(PolygonChange(99f, "8R"));
		StartCoroutine(PolygonChange(112f, "4S"));
		Invoke("SpiralRandomChange", 114f);
		//HARDMODE//
		StartCoroutine(PolygonChange(125.3f, "5"));
		StartCoroutine(PolygonChange(143.3f, "6R"));
		StartCoroutine(PolygonChange(156.7f, "4R"));
		StartCoroutine(PolygonChange(170f, "6S"));
		StartCoroutine(PolygonChange(183f, "8S"));
		Invoke("SpiralRandomChange", 184f);
		Invoke("SpiralDirectionChange", 187.7f);
		Invoke("SpiralDirectionChange", 189.3f);
		Invoke("SpiralDirectionChange", 191f);
		Invoke("SpiralDirectionChange", 194.3f);


		//ShrinkSpeed//
		StartCoroutine(ShrinkSpeed(5f, 1.7f));
		StartCoroutine(ShrinkSpeed(18.1f, 1.8f));
		StartCoroutine(ShrinkSpeed(31.3f, 1.5f));
		StartCoroutine(ShrinkSpeed(41f, 1.7f));
		StartCoroutine(ShrinkSpeed(61f, 1.2f));
		StartCoroutine(ShrinkSpeed(74.3f, 1.1f));
		StartCoroutine(ShrinkSpeed(87.5f, 1.6f));
		StartCoroutine(ShrinkSpeed(101f, 1.8f));
		StartCoroutine(ShrinkSpeed(114f, 1.1f));
		StartCoroutine(ShrinkSpeed(114.9f, 1.3f));
		//HARDMODE//
		StartCoroutine(ShrinkSpeed(127.3f, 2f));
		StartCoroutine(ShrinkSpeed(134f, 2.1f));
		StartCoroutine(ShrinkSpeed(140.6f, 2f));
		StartCoroutine(ShrinkSpeed(141f, 1.9f));
		StartCoroutine(ShrinkSpeed(145.3f, 2f));
		StartCoroutine(ShrinkSpeed(159.9f, 2.1f));
		StartCoroutine(ShrinkSpeed(172f, 1.6f));
		StartCoroutine(ShrinkSpeed(185f, 1.1f));

		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(44.5f, 0.75f));
		StartCoroutine(SpawnRate(61f, 0.9f));
		StartCoroutine(SpiralSRate(61f, 0.3f));
		StartCoroutine(SpiralSRate(87.5f, 0.25f));
		StartCoroutine(SpawnRate(101f, 0.75f));
		StartCoroutine(SpiralSRate(114f, 0.45f));
		//HARDMODE//
		StartCoroutine(SpawnRate(127.3f, 0.6f));
		StartCoroutine(SpiralSRate(172f, 0.35f));
		StartCoroutine(SpiralSRate(185f, 0.1f));
		StartCoroutine(SpawnRate(197f, 0.6f));
		StartCoroutine(SpawnRate(197f, 1.05f));

		//Direction//
		Invoke("Direction", 11.5f);
		Invoke("Direction", 18.1f);
		Invoke("Direction", 24.9f);
		Invoke("Direction", 34.5f);
		Invoke("Direction", 36.3f);
		Invoke("Direction", 41.2f);
		Invoke("Direction", 44.5f);
		Invoke("Direction", 48f);
		Invoke("Direction", 49.5f);
		Invoke("Direction", 51.3f);
		Invoke("Direction", 67.9f);
		Invoke("Direction", 74.3f);
		Invoke("Direction", 87.5f);
		Invoke("Direction", 94.5f);
		Invoke("Direction", 101f);
		Invoke("Direction", 107.7f);
		Invoke("Direction", 114.1f);
		Invoke("Direction", 114.8f);
		Invoke("Direction", 115.5f);
		Invoke("Direction", 116.1f);
		Invoke("Direction", 118.1f);
		Invoke("Direction", 119.2f);
		Invoke("Direction", 120.9f);
		Invoke("Direction", 122f);
		Invoke("Direction", 123.3f);
		Invoke("Direction", 124.1f);
		Invoke("Direction", 125.4f);
		//HARDMODE//
		Invoke("Direction", 127.4f);
		Invoke("Direction", 130.9f);
		Invoke("Direction", 134f);
		Invoke("Direction", 137.3f);
		Invoke("Direction", 145.6f);
		Invoke("Direction", 158.9f);
		Invoke("Direction", 172.1f);
		Invoke("Direction", 178.5f);
		Invoke("Direction", 185.4f);
		Invoke("Direction", 192.1f);

		//CameraRotationSpeed//
		StartCoroutine(CameraRotation(5f, 50f));
		StartCoroutine(CameraRotation(7f, 25f));
		StartCoroutine(CameraRotation(11.5f, 50f));
		StartCoroutine(CameraRotation(13.5f, 25f));
		StartCoroutine(CameraRotation(18.1f, 50f));
		StartCoroutine(CameraRotation(20.1f, 25f));
		StartCoroutine(CameraRotation(24.9f, 50f));
		StartCoroutine(CameraRotation(26.9f, 25f));
		StartCoroutine(CameraRotation(31.3f, 75f));
		StartCoroutine(CameraRotation(32.3f, 50f));
		StartCoroutine(CameraRotation(33.3f, 25f));
		StartCoroutine(CameraRotation(34.5f, 50f));
		StartCoroutine(CameraRotation(38.1f, 75f));
		StartCoroutine(CameraRotation(39.3f, 50f));
		StartCoroutine(CameraRotation(40.5f, 25f));
		StartCoroutine(CameraRotation(41.2f, 75f));
		StartCoroutine(CameraRotation(58f, 0f));
		StartCoroutine(CameraRotation(59.5f, 25f));
		StartCoroutine(CameraRotation(61f, 100f));
		StartCoroutine(CameraRotation(73.5f, 50f));
		StartCoroutine(CameraRotation(74.3f, 125f));
		StartCoroutine(CameraRotation(87.5f, 150f));
		StartCoroutine(CameraRotation(101f, 175f));
		StartCoroutine(CameraRotation(114.1f, 0f));
		StartCoroutine(CameraRotation(114.8f, 175f));
		StartCoroutine(CameraRotation(115.5f, 0f));
		StartCoroutine(CameraRotation(116.1f, 175f));
		StartCoroutine(CameraRotation(117.5f, 0f));
		StartCoroutine(CameraRotation(118.1f, 175f));
		StartCoroutine(CameraRotation(118.9f, 0f));
		StartCoroutine(CameraRotation(119.3f, 175f));
		StartCoroutine(CameraRotation(120.9f, 0f));
		StartCoroutine(CameraRotation(121.4f, 175f));
		StartCoroutine(CameraRotation(122f, 0f));
		StartCoroutine(CameraRotation(122.8f, 175f));
		StartCoroutine(CameraRotation(123.3f, 75f));
		StartCoroutine(CameraRotation(123.8f, 0f));
		StartCoroutine(CameraRotation(124.1f, 175f));
		StartCoroutine(CameraRotation(124.8f, 0f));
		StartCoroutine(CameraRotation(125.4f, 175f));
		StartCoroutine(CameraRotation(126f, 150f));
		StartCoroutine(CameraRotation(126.1f, 125f));
		StartCoroutine(CameraRotation(126.2f, 100f));
		StartCoroutine(CameraRotation(126.3f, 75f));
		StartCoroutine(CameraRotation(126.4f, 50f));
		StartCoroutine(CameraRotation(126.5f, 25f));
		StartCoroutine(CameraRotation(126.6f, 0f));
		StartCoroutine(CameraRotation(127.2f, 175f));
		//HARDMODE//
		StartCoroutine(CameraRotation(129.1f, 150f));
		StartCoroutine(CameraRotation(129.6f, 125f));
		StartCoroutine(CameraRotation(129.8f, 100f));
		StartCoroutine(CameraRotation(130f, 75f));
		StartCoroutine(CameraRotation(130.8f, 175f));
		StartCoroutine(CameraRotation(132.7f, 125f));
		StartCoroutine(CameraRotation(133.2f, 100f));
		StartCoroutine(CameraRotation(133.4f, 75f));
		StartCoroutine(CameraRotation(133.6f, 50f));
		StartCoroutine(CameraRotation(134f, 175f));
		StartCoroutine(CameraRotation(135.9f, 125f));
		StartCoroutine(CameraRotation(136.1f, 100f));
		StartCoroutine(CameraRotation(136.3f, 75f));
		StartCoroutine(CameraRotation(136.5f, 50f));
		StartCoroutine(CameraRotation(137.4f, 150f));
		StartCoroutine(CameraRotation(139.1f, 175f));
		StartCoroutine(CameraRotation(139.9f, 200f));
		StartCoroutine(CameraRotation(139.9f, 225f));
		StartCoroutine(CameraRotation(140.3f, 50f));
		StartCoroutine(CameraRotation(145.4f, 125f));
		StartCoroutine(CameraRotation(158f, 50f));
		StartCoroutine(CameraRotation(158.9f, 125f));
		StartCoroutine(CameraRotation(170.5f, 100f));
		StartCoroutine(CameraRotation(171f, 75f));
		StartCoroutine(CameraRotation(171.5f, 50f));
		StartCoroutine(CameraRotation(172f, 25f));
		StartCoroutine(CameraRotation(172.3f, 50f));
		StartCoroutine(CameraRotation(183.5f, 0f));
		StartCoroutine(CameraRotation(185.3f, 25f));
		StartCoroutine(CameraRotation(197f, 0f));


		Invoke("End", 197f);

		StartCoroutine(HardMode(126.1f));
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