using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    
    void OnTriggerEnter(Collider Coal)
    {
        if(Coal.tag == "Player")
        {
            Destroy(gameObject);
        }
    }


    
}
