using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour{
	public float Speed;
	public Animator PlayerAnim;
	private int RealMovement;
	public static int Direction = 1;

	void FixedUpdate(){
		// Movement script - disables player acceleration
		if(Input.GetAxis("Horizontal") > 0){
			RealMovement = 1;
		}
		if(Input.GetAxis("Horizontal") < 0){
			RealMovement = -1;
		}
		if(Input.GetAxis("Horizontal") == 0){
			RealMovement = 0;
		}
		PlayerAnim.SetFloat("Move",Input.GetAxis("Horizontal"));

		// Exit game
		if(Input.GetKeyDown("escape")){
			SceneManager.LoadScene("Menu", LoadSceneMode.Single);
		}
		// Reset game
		if (Input.GetKeyDown("r")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		// Camera rotation - Input*Time*-Speed*Direction
		transform.RotateAround(Vector3.zero, Vector3.forward, RealMovement * Time.fixedDeltaTime * -Speed * Direction);
	}
}
