using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour{
	public Text HSLevel, Credits2, Credits1;
	public Animator CenterAnim, BGAnim;
	private int BGShape, LastBGShape;

	// Level 1
	public void ID1(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L1").ToString("F1")+" -";
		Credits1.text = "Song: Jack Russel";
		Credits2.text = "Author: Bossfight";
		BGShape = 4;
	}
	// Level 2
	public void ID2(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L2").ToString("F1")+" -";
		Credits1.text = "Song: Steampunk Warlord";
		Credits2.text = "Author: Bossfight";
		BGShape = 4;
	}
	// Level 3
	public void ID3(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L3").ToString("F1")+" -";
		Credits1.text = "Song: Commando Steve";
		Credits2.text = "Author: Bossfight";
		BGShape = 5;
	}
	// Level 4
	public void ID4(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L4").ToString("F1")+" -";
		Credits1.text = "Song: The Maze of Mayonaisse";
		Credits2.text = "Author: Bossfight";
		BGShape = 5;
	}
	// Level 5
	public void ID5(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L5").ToString("F1")+" -";
		Credits1.text = "Song: Spectra";
		Credits2.text = "Author: Chipzel";
		BGShape = 6;
	}
	// Level 6
	public void ID6(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L6").ToString("F1")+" -";
		Credits1.text = "Song: Milky Ways";
		Credits2.text = "Author: Bossfight";
		BGShape = 6;
	}
	// Level 7
	public void ID7(){
		HSLevel.text = "- "+PlayerPrefs.GetFloat("L7").ToString("F1")+" -";
		Credits1.text = "Song: Focus";
		Credits2.text = "Author: Chipzel";
		BGShape = 8;
	}
	// Nothing
	public void None(){
		HSLevel.text = "- ### -";
		Credits2.text = "Author: TheNexTST";
		Credits1.text = "Level Design: SaneronTB";
	}
	// Default
	void Start(){
		None();
		BG.Color1 = new Color(239/255f, 239/255f, 239/255f);
		BG.Color2 = new Color(209/255f, 209/255f, 209/255f);
		LastBGShape = 4;
	}

	void Update(){
		// Quit game
		if (Input.GetKeyDown("escape")){
			Application.Quit();
		}
		// Reset scores
		if (Input.GetKeyDown("delete")){
			PlayerPrefs.SetFloat("L1", 0);
			PlayerPrefs.SetFloat("L2", 0);
			PlayerPrefs.SetFloat("L3", 0);
			PlayerPrefs.SetFloat("L4", 0);
			PlayerPrefs.SetFloat("L5", 0);
			PlayerPrefs.SetFloat("L6", 0);
			PlayerPrefs.SetFloat("L7", 0);
		}
		if(BGShape != LastBGShape){
			LastBGShape = BGShape;
			CenterAnim.SetInteger("Shape", BGShape);
			BGAnim.SetInteger("Shape", BGShape);
		}
	}
}