using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideW : MonoBehaviour
{
    private int _deg,_sides;
	void Start(){
		if(Spawner.isRandom && !Spawner.isSpiral){
      switch (Spawner.Polygon){
				case "4": { _deg = 90; _sides=4; break; }
				case "5": { _deg = 72; _sides=5; break; }
				case "6": { _deg = 60; _sides=6; break; }
				case "8": { _deg = 45; _sides=8; break; }
			}
			if(Spawner.WallPos!=-1){
				transform.localRotation = Quaternion.Euler(0, 0, Spawner.WallPos*_deg);
			}
			else{
				transform.localRotation = Quaternion.Euler(0, 0, Random.Range(0, _sides)*_deg);

			}
		}
	}
}