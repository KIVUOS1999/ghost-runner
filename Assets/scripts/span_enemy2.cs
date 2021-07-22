using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class span_enemy2 : MonoBehaviour
{
    public GameObject enemy;
    Vector2 position;
    float randx;
    public float spanning_rate;
    float next_span = 0.2f;


    void Update()
    {
        if(Time.time > next_span)
        {
            next_span = Time.time+spanning_rate ;
            randx = Random.Range(-4.07f,4.03f);
            position =new Vector2(9.03f,randx);
            Instantiate(enemy,position,Quaternion.identity);
        }
    }
}
