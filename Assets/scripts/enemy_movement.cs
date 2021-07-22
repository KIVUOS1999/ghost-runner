using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{    
    public float mov_speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start() {
        rb = this.GetComponent<Rigidbody2D>();  
    }

    void FixedUpdate() 
    {
        GameObject ss = GameObject.Find("robo");
        Transform player = ss.GetComponent<Transform>();
        
        Vector2 direction = player.position - rb.transform.position;
        float z = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = z;
        direction.Normalize();
        rb.MovePosition(rb.position + direction*mov_speed*Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
