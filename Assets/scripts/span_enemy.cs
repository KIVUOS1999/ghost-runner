using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class span_enemy : MonoBehaviour
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
            randx = Random.Range(-9.07f,9.03f);
            position =new Vector2(randx, 3.93f);
            Instantiate(enemy,position,Quaternion.identity);
        }
    }
}
