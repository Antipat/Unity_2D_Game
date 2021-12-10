using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_fire : MonoBehaviour
{
        GameObject pers;
        Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pers = GameObject.FindWithTag("Player");
        pos = pers.transform.position;
    }

    void  OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, pos, 10.0f*Time.deltaTime);
    
    if (transform.position.x >= pos.x && transform.position.y >= pos.y)
    {
        Destroy(gameObject);
    }
    }
}
