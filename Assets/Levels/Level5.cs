using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5 : MonoBehaviour{
	public AudioSource AudioControllerSource;
	public AudioClip HardModeClip,DirectionClip;
	void Start(){
		// Script :v //

		GameCamera.Rotation = 30;
		Score.LVLID = "L5";
		Score.LVLEND = 234;
		Polygon.ShrinkSpeed = 1.75f;
		Spawner.RandomRotation = false;
		Player.Direction = 1;
		BG.Color1 = new Color(68/255f, 86/255f, 159/255f);
		BG.Color2 = new Color(176/255f, 65/255f, 181/255f);


		// Saneron ;) //

		// Polygons //
		Invoke("Open", 0f);
		StartCoroutine(PolygonChange(0f, "6"));
		StartCoroutine(PolygonChange(16.5f, "6"));
		StartCoroutine(PolygonChange(23.5f, "4"));
		StartCoroutine(PolygonChange(38f, "4"));
		Invoke("PlayerDirection", 25f);
		Invoke("PlayerDirection", 39.5f);
		StartCoroutine(PolygonChange(52.5f, "8"));
		Invoke("PlayerDirection", 54.2f);
		Invoke("PlayerDirection", 69.5f);
		StartCoroutine(PolygonChange(82f, "5"));
		Invoke("PlayerDirection", 84f);
		Invoke("PlayerDirection", 91.3f);
		Invoke("PlayerDirection", 98.8f);
		Invoke("PlayerDirection", 106f);
		StartCoroutine(PolygonChange(111.5f, "6"));
		Invoke("Random", 112.5f);
		Invoke("Direction", 121f);
		StartCoroutine(PolygonChange(126f, "5"));
		Invoke("PlayerDirection", 128f);
		Invoke("Direction", 135.7f);
		Invoke("Direction", 143.2f);
		StartCoroutine(PolygonChange(141.2f, "8"));
		Invoke("Spiral", 142.2f);
		Invoke("Open", 142.2f);
		Invoke("SpiralRandomChange", 143.2f);
		StartCoroutine(PolygonChange(155.8f, "6"));
		Invoke("Spiral", 156.8f);
		Invoke("Open", 156.8f);
		Invoke("Random", 156.8f);
		Invoke("PlayerDirection", 157.8f);

		StartCoroutine(PolygonChange(170.5f, "8"));
		Invoke("Random", 171.5f);
		StartCoroutine(PolygonChange(178f, "6"));
		Invoke("RandomRotation", 185f);
		StartCoroutine(PolygonChange(185f, "5"));
		Invoke("Spiral", 186f);
		Invoke("Open", 186f);
		Invoke("SpiralRandomChange", 187f);
		Invoke("SpiralDirectionChange", 194.7f);
		Invoke("SpiralDirectionChange", 200f);
		Invoke("PlayerDirection", 187f);
		Invoke("Direction", 194.7f);
		StartCoroutine(PolygonChange(200f, "4"));
		Invoke("Spiral", 201f);
		Invoke("Open", 201f);
		Invoke("Random", 201f);
		Invoke("RandomRotation", 202f);
		Invoke("PlayerDirection", 202f);
		StartCoroutine(PolygonChange(215f, "6"));
		Invoke("Random", 216f);
		Invoke("PlayerDirection", 217f);



		// Shrinks //
		StartCoroutine(ShrinkSpeed(25f, 1.6f));
		StartCoroutine(ShrinkSpeed(39.5f, 1.8f));
		StartCoroutine(ShrinkSpeed(54.5f, 1.8f));
		StartCoroutine(ShrinkSpeed(69f, 2f));
		StartCoroutine(ShrinkSpeed(84f, 1.75f));
		StartCoroutine(ShrinkSpeed(113.5f, 1.8f));
		StartCoroutine(ShrinkSpeed(128.3f, 2f));
		StartCoroutine(ShrinkSpeed(143.2f, 1f));
		StartCoroutine(ShrinkSpeed(156.9f, 0f));

		StartCoroutine(ShrinkSpeed(157.9f, 1.5f));
		StartCoroutine(ShrinkSpeed(158f, 0.75f));
		StartCoroutine(ShrinkSpeed(158.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(159f, 0.75f));
		StartCoroutine(ShrinkSpeed(159.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(160f, 0.75f));
		StartCoroutine(ShrinkSpeed(160.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(161f, 0.75f));
		StartCoroutine(ShrinkSpeed(161.5f, 1.5f));

		StartCoroutine(ShrinkSpeed(165f, 1.5f));
		StartCoroutine(ShrinkSpeed(165.5f, 0.75f));
		StartCoroutine(ShrinkSpeed(166f, 1.5f));
		StartCoroutine(ShrinkSpeed(166.5f, 0.75f));
		StartCoroutine(ShrinkSpeed(167f, 1.5f));
		StartCoroutine(ShrinkSpeed(167.5f, 0.75f));
		StartCoroutine(ShrinkSpeed(168f, 1.5f));
		StartCoroutine(ShrinkSpeed(168.5f, 0.75f));
		StartCoroutine(ShrinkSpeed(169f, 1.5f));

		StartCoroutine(ShrinkSpeed(172.5f, 1f));
		StartCoroutine(ShrinkSpeed(176f, 1.5f));
		StartCoroutine(ShrinkSpeed(180f, 1f));
		StartCoroutine(ShrinkSpeed(183.5f, 1.5f));
		StartCoroutine(ShrinkSpeed(187f, 1.3f));
		StartCoroutine(ShrinkSpeed(202f, 1.5f));
		StartCoroutine(ShrinkSpeed(217f, 1.8f));
		StartCoroutine(ShrinkSpeed(234f, 1f));



		//spiral 0.2, polygons 0.9
		// up = -, down = +
		//SpawnRate//
		StartCoroutine(SpawnRate(25f, 1.05f));
		StartCoroutine(SpawnRate(39.5f, 0.8f));
		StartCoroutine(SpawnRate(54.5f, 1.85f));
		StartCoroutine(SpawnRate(84f, 0.75f));
		StartCoroutine(SpawnRate(89f, 2f));
		StartCoroutine(SpawnRate(91f, 0.75f));
		StartCoroutine(SpawnRate(96.5f, 2f));
		StartCoroutine(SpawnRate(98.5f, 0.75f));
		StartCoroutine(SpawnRate(104f, 2f));
		StartCoroutine(SpawnRate(106f, 0.75f));
		StartCoroutine(SpawnRate(113.5f, 0.85f));
		StartCoroutine(SpiralSRate(143.2f, 0.35f));
		StartCoroutine(SpawnRate(156.5f, 1f));

		StartCoroutine(SpawnRate(157.5f, 0.75f));

		StartCoroutine(SpawnRate(172.5f, 0.75f));
		StartCoroutine(SpiralSRate(187f, 0.2f));
		StartCoroutine(SpawnRate(202f, 1f));
		StartCoroutine(SpawnRate(217f, 1.85f));
		StartCoroutine(SpawnRate(234f, 1f));



		// Camera Rotation //
		StartCoroutine(CameraRotation(13.8f, 60f));
		StartCoroutine(CameraRotation(17.5f, 30f));
		StartCoroutine(CameraRotation(21.2f, 60f));
		StartCoroutine(CameraRotation(24f, 120f));
		StartCoroutine(CameraRotation(25f, 60f));
		StartCoroutine(CameraRotation(28.5f, 90f));
		StartCoroutine(CameraRotation(32.2f, 60f));
		StartCoroutine(CameraRotation(36f, 90f));
		StartCoroutine(CameraRotation(39.4f, 60f));
		StartCoroutine(CameraRotation(52.5f, 0f));
		StartCoroutine(CameraRotation(54.5f, 90f));
		StartCoroutine(CameraRotation(69f, 120f));
		StartCoroutine(CameraRotation(81.5f, 90f));
		StartCoroutine(CameraRotation(82f, 60f));
		StartCoroutine(CameraRotation(82.5f, 30f));
		StartCoroutine(CameraRotation(84f, 120f));
		StartCoroutine(CameraRotation(112.5f, 60f));
		StartCoroutine(CameraRotation(113.5f, 30f));
		StartCoroutine(CameraRotation(114.5f, 60f));
		StartCoroutine(CameraRotation(115.5f, 90f));
		StartCoroutine(CameraRotation(116.5f, 120f));
		StartCoroutine(CameraRotation(118.5f, 90f));
		StartCoroutine(CameraRotation(119.5f, 60f));
		StartCoroutine(CameraRotation(121f, 30f));
		StartCoroutine(CameraRotation(122f, 60f));
		StartCoroutine(CameraRotation(123f, 90f));
		StartCoroutine(CameraRotation(124f, 120f));
		StartCoroutine(CameraRotation(126f, 90f));
		StartCoroutine(CameraRotation(127f, 60f));
		StartCoroutine(CameraRotation(128f, 30f));
		StartCoroutine(CameraRotation(129.2f, 60f));
		StartCoroutine(CameraRotation(130.2f, 90f));
		StartCoroutine(CameraRotation(131.2f, 120f));
		StartCoroutine(CameraRotation(135.7f, 30f));
		StartCoroutine(CameraRotation(136.7f, 60f));
		StartCoroutine(CameraRotation(137.7f, 90f));
		StartCoroutine(CameraRotation(138.7f, 120f));
		StartCoroutine(CameraRotation(143.2f, 90f));

		StartCoroutine(CameraRotation(156.9f, 0f));
		StartCoroutine(CameraRotation(157.9f, 90f));
		StartCoroutine(CameraRotation(172.5f, 30f));
		StartCoroutine(CameraRotation(176f, 90f));
		StartCoroutine(CameraRotation(180f, 30f));
		StartCoroutine(CameraRotation(183.5f, 90f));
		StartCoroutine(CameraRotation(187f, 120f));
		StartCoroutine(CameraRotation(194.7f, 150f));
		StartCoroutine(CameraRotation(202f, 30f));
		StartCoroutine(CameraRotation(233f, 24f));
		StartCoroutine(CameraRotation(233.5f, 18f));
		StartCoroutine(CameraRotation(234f, 12f));
		StartCoroutine(CameraRotation(234.5f, 6f));
		StartCoroutine(CameraRotation(235f, 0f));


		// Color //
		StartCoroutine (Color1(232f, 175, 175, 175));
		StartCoroutine (Color2(232f, 125, 125, 125));



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
	IEnumerator Color1(float time, int R, int G, int B){
		yield return new WaitForSeconds(time);
		BG.Color1 = new Color(R / 255f, G / 255f, B / 255f);
	}
	IEnumerator Color2(float time, int R, int G, int B){
		yield return new WaitForSeconds(time);
		BG.Color2 = new Color(R / 255f, G / 255f, B / 255f);
	}
}