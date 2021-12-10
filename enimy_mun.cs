using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy_mun : MonoBehaviour
{

     float speed;
    GameObject pers;
    public GameObject mun;
    float t1;
    float x;
    bool b;
    // Start is called before the first frame update
    void Start()
    {
        x=0.01f;
       pers = GameObject.FindWithTag("Player");
        speed = 0.5f;
        // делаем невидимым меч
        mun.transform.localScale = new Vector3(x,0.03f,0.0f);
        t1=0.5f; 
        b=false;
    }

    // Update is called once per frame
    void Update()
    {
        t1 -=Time.deltaTime;
        if (t1 <=0.0 && b==false)
        {
            x+=0.05f;
            mun.transform.localScale = new Vector3(x,0.03f,0.0f);
            t1=0.5f;
        }
        if (x >=0.2f&&b==false)
        {
            speed = 2.0f;
            b=true;
        }
        if (b==true)
        {
            x-=0.1f*Time.deltaTime;
            mun.transform.localScale = new Vector3(x,0.03f,0.0f);
        }
        if(x<=0.01f)
        {
            b=false;
            x=0.01f;
            speed = 0.5f;
        }

        float step = speed*Time.deltaTime;
        float dist = Vector3.Distance(pers.transform.position, transform.position);
        if (dist >1.0f && dist <7.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, pers.transform.position, step);

        }
        
    }
}
