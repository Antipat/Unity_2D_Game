using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimy : MonoBehaviour
{
    float speed;
    GameObject pers;
    public GameObject mech;

    // Start is called before the first frame update
    void Start()
    {
        // нахождение игрока
        pers = GameObject.FindWithTag("Player");
        speed = 1.5f;
        // делаем невидимым меч
        mech.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed*Time.deltaTime;
        float dist = Vector3.Distance(pers.transform.position, transform.position);
       // Debug.Log("dist = "+ dist.ToString());

        if (dist >1.0f && dist <7.0f)
        {
            Vector3 vec  = pers.transform.position - transform.position;
            //Vector3 newangle = Vector3.RotateTowards(transform.right, vec, step, 0.0f);
            //transform.rotation = Quaternion.LookRotation (newangle);
            transform.position = Vector3.MoveTowards(transform.position, pers.transform.position, step);
        if (dist>1.0f && dist<2.5f)
        {
            mech.SetActive(true);
        }

        else if(dist>=2.5)
        {
            mech.SetActive(false);
        }
        
        }

    }
}
