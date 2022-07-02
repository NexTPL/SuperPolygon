using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4 : MonoBehaviour{
	public AudioSource HardPlayer;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 30;
		Score.LVLID = "L4";
		Score.LVLEND = 188;
		Polygon.ShrinkSpeed = 1.6f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(0/255f, 130/255f, 245/255f);
		BG.Color2 = new Color(113/255f, 40/255f, 255/255f);
		


		// Saneron ;) //

		// Polygons //
		Invoke("RandomRotation", 10f);
		StartCoroutine(PolygonChange(11f, "5R"));
		StartCoroutine(PolygonChange(17.2f, "5"));
		StartCoroutine(PolygonChange(24.8f, "5R"));
		StartCoroutine(PolygonChange(33.6f, "6"));
		Invoke("RandomRotation", 35.6f);
		Invoke("RandomRotation", 41.8f);
		StartCoroutine(PolygonChange(49.5f, "6R"));
		StartCoroutine(PolygonChange(62f, "5"));
		StartCoroutine(PolygonChange(76.4f, "6S"));
		Invoke("SpiralRandomChange", 78.4f);
		StartCoroutine(PolygonChange(90.5f, "8"));
		StartCoroutine(PolygonChange(104.7f, "6"));
		Invoke("RandomRotation", 104.7f);
		Invoke("RandomRotation", 109f);
		StartCoroutine(PolygonChange(111.5f, "5"));
		Invoke("RandomRotation", 116.5f);
		StartCoroutine(PolygonChange(119f, "4"));
		Invoke("RandomRotation", 135f);
		StartCoroutine(PolygonChange(133f, "6R"));
		StartCoroutine(PolygonChange(149f, "5"));
		Invoke("SpiralRandomChange", 163f);
		StartCoroutine(PolygonChange(163.5f, "8S"));
		Invoke("SpiralDirectionChange", 168.5f);
		Invoke("SpiralDirectionChange", 170f);
		Invoke("SpiralRandomChange", 172f);
		Invoke("SpiralRandomChange", 177f);
		StartCoroutine(PolygonChange(177.8f, "6"));

		


		// Shrinks //
		StartCoroutine(ShrinkSpeed(13f, 1.45f));
		StartCoroutine(ShrinkSpeed(51.5f, 1.75f));
		StartCoroutine(ShrinkSpeed(78.4f, 1.55f));
		StartCoroutine(ShrinkSpeed(92.5f, 1.65f));
		StartCoroutine(ShrinkSpeed(104.7f, 1.9f));
		StartCoroutine(ShrinkSpeed(121f, 1.85f));
		StartCoroutine(ShrinkSpeed(128f, 1.75f));
		StartCoroutine(ShrinkSpeed(135f, 1.75f));
		StartCoroutine(ShrinkSpeed(148.5f, 0f));
		StartCoroutine(ShrinkSpeed(149.5f, 0.3f));
		StartCoroutine(ShrinkSpeed(149.6f, 0.6f));
		StartCoroutine(ShrinkSpeed(149.7f, 0.9f));
		StartCoroutine(ShrinkSpeed(149.8f, 1.2f));
		StartCoroutine(ShrinkSpeed(149.9f, 1.5f));
		StartCoroutine(ShrinkSpeed(150f, 1.8f));
		StartCoroutine(ShrinkSpeed(150.1f, 2.1f));
		StartCoroutine(ShrinkSpeed(150.2f, 2.4f));
		StartCoroutine(ShrinkSpeed(151f, 1.8f));
		StartCoroutine(ShrinkSpeed(165f, 2f));
		StartCoroutine(ShrinkSpeed(172f, 1.5f));
		StartCoroutine(ShrinkSpeed(172f, 2f));
		StartCoroutine(ShrinkSpeed(179.5f, 1.45f));
		StartCoroutine(ShrinkSpeed(179.5f, 1.3f));


		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(26.8f, 0.75f));
		StartCoroutine(SpawnRate(51.5f, 0.6f));
		StartCoroutine(SpawnRate(62f, 0.65f));
		StartCoroutine(SpiralSRate(78.4f, 0.3f));
		StartCoroutine(SpawnRate(92f, 0.9f));
		StartCoroutine(SpawnRate(104.7f, 0.75f));
		StartCoroutine(SpawnRate(121f, 0.5f));
		StartCoroutine(SpawnRate(128f, 0.6f));
		StartCoroutine(SpawnRate(135f, 0.5f));
		StartCoroutine(SpawnRate(148f, 1f));
		StartCoroutine(SpawnRate(151f, 0.5f));
		StartCoroutine(SpiralSRate(165f, 0.15f));
		StartCoroutine(SpiralSRate(172f, 0.2f));
		StartCoroutine(SpawnRate(179.5f, 0.75f));
		StartCoroutine(SpawnRate(187f, 0.6f));


		// Camera Rotation //
		StartCoroutine(CameraRotation(17.5f, 60f));
		StartCoroutine(CameraRotation(24.8f, 90f));
		StartCoroutine(CameraRotation(31.8f, 120f));
		StartCoroutine(CameraRotation(33.8f, 0f));
		StartCoroutine(CameraRotation(35.6f, 120f));
		StartCoroutine(CameraRotation(49.7f, 90f));
		StartCoroutine(CameraRotation(50.1f, 60f));
		StartCoroutine(CameraRotation(50.5f, 30f));
		StartCoroutine(CameraRotation(51.5f, 90f));
		StartCoroutine(CameraRotation(64f, 120f));
		StartCoroutine(CameraRotation(78.2f, 40f));
		StartCoroutine(CameraRotation(85.4f, 60f));
		StartCoroutine(CameraRotation(90.5f, 0f));
		StartCoroutine(CameraRotation(92.5f, 60f));
		StartCoroutine(CameraRotation(103f, 90f));
		StartCoroutine(CameraRotation(104.9f, 120f));
		StartCoroutine(CameraRotation(105.4f, 150f));
		StartCoroutine(CameraRotation(105.9f, 180f));
		StartCoroutine(CameraRotation(106.7f, 0f));
		StartCoroutine(CameraRotation(121f, 30f));
		StartCoroutine(CameraRotation(128f, 75f));
		StartCoroutine(CameraRotation(135f, 150f));
		StartCoroutine(CameraRotation(148.5f, 30f));
		StartCoroutine(CameraRotation(151f, 180f));
		StartCoroutine(CameraRotation(165f, 60f));
		StartCoroutine(CameraRotation(172.5f, 120f));
		StartCoroutine(CameraRotation(179.5f, 45f));
		StartCoroutine(CameraRotation(186.5f, 15f));


		// Direction //
		Invoke("Direction", 19.5f);
		Invoke("Direction", 26.8f);
		Invoke("Direction", 42.8f);
		Invoke("Direction", 51.5f);
		Invoke("Direction", 58.8f);
		Invoke("Direction", 62f);
		Invoke("Direction", 62.5f);
		Invoke("Direction", 63f);
		Invoke("Direction", 64f);
		Invoke("Direction", 71f);
		Invoke("Direction", 85.4f);
		Invoke("Direction", 92.5f);
		Invoke("Direction", 99.7f);
		Invoke("Direction", 134.7f);
		Invoke("Direction", 144f);
		Invoke("Direction", 147.75f);
		Invoke("Direction", 148f);
		Invoke("Direction", 148.25f);
		Invoke("Direction", 148.5f);
		Invoke("Direction", 165f);
		Invoke("Direction", 172.5f);
		Invoke("Direction", 186.5f);



		Invoke("End", 184.5f);

		StartCoroutine(HardMode(120f));
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