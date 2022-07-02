using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallO : MonoBehaviour
{
    void Start()
    {
        if(Spawner.isOpen == true){
            gameObject.SetActive(false);
        }
        else{
            return;
        }
    }
}
