using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour{
	public void LoadL1(){
		// Load level 1
		SceneManager.LoadScene("Level1", LoadSceneMode.Single);
	}
	public void LoadL2(){
		// Load level 2
		SceneManager.LoadScene("Level2", LoadSceneMode.Single);
	}
	public void LoadL3(){
		// Load level 3
		SceneManager.LoadScene("Level3", LoadSceneMode.Single);
	}
	public void LoadL4(){
		// Load level 4
		SceneManager.LoadScene("Level4", LoadSceneMode.Single);
	}
	public void LoadL5(){
		// Load level 5
		SceneManager.LoadScene("Level5", LoadSceneMode.Single);
	}
	public void LoadL6(){
		// Load level 6
		SceneManager.LoadScene("Level6", LoadSceneMode.Single);
	}
	public void LoadL7(){
		// Load level 7
		SceneManager.LoadScene("Level7", LoadSceneMode.Single);
	}
	public void LoadERROR(){
		// Load Error
		SceneManager.LoadScene("TEST", LoadSceneMode.Single);
	}

}