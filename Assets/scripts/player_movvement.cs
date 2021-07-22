using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movvement : MonoBehaviour
{
    public int max_health = 20;
    public GameObject died;
    public int damage_induce;
    public int curr_health;
    public float movement_speed;
    public Rigidbody2D rb;
    Vector2 movement, mousepos;
    public Camera cam;
    public health_bar hb;

    // Update is called once per frame

    void Start() {
        curr_health = max_health;
        hb.max_health(max_health);    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);

        if(curr_health <= 0)
        {
            died.SetActive(true);
        }
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement*movement_speed*Time.deltaTime);
        Vector2 look = mousepos - rb.position;
        float z = Mathf.Atan2(look.y, look.x)*Mathf.Rad2Deg - 90f;
        rb.rotation = z;
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.collider.tag == "enemy")
        {
            TakeDamage(damage_induce);
        }
    }
    void TakeDamage(int data)
    {
        curr_health-=data;
        hb.SetHealth(curr_health);
    }
}
