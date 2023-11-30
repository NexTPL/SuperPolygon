using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
	int _deg, _offset;
    void Start()
    {
      switch (Spawner.Polygon){
				case "4": { _deg = 90; _offset = 180; break; }
				case "5": { _deg = 72; _offset = 0;break; }
				case "6": { _deg = 60; _offset = 180;break; }
				case "8": { _deg = 45; _offset = 180;break; }
			}
			transform.localRotation = Quaternion.Euler(0, 0, _offset+Spawner.WallPos*_deg);
    }

	void FixedUpdate(){
		if (transform.localScale.x > 0.22f || Spawner.remWall){
			transform.localScale -= Vector3.one * (Polygon.ShrinkSpeed * Time.deltaTime * (4/2.8f));
			if (transform.localScale.x < 0.01f){
				Spawner.remWall = false;
				Spawner.WallPos = -1;
				Destroy(gameObject);
			}
		}
	}
}
