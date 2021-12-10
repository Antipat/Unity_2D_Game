using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy_gun : MonoBehaviour
{
    GameObject pers;
    Transform a;
    public Transform prefab;

    float t=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        pers = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(pers.transform.position, transform.position);
        Vector3 fire = pers.transform.position - transform.position;

        if (dist<10.0f)
        {
            t -=Time.deltaTime;
            // создание пули (стрелы)
            if (t<=0.0f){
            a = Instantiate(prefab, transform.position, transform.rotation);
            t=1.0f;
        }
            
        }
    }
}
