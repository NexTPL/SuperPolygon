using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideO : MonoBehaviour
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
