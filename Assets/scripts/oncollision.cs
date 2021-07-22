using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oncollision : MonoBehaviour
{    
    public GameObject hit_effect;
    

    void OnCollisionEnter2D(Collision2D collision) {
        GameObject t = (GameObject.Find("score"));
        Text tt = t.GetComponent<Text>(); 
        tt.text = (System.Int32.Parse(tt.text)+1).ToString();


        GameObject effect = Instantiate(hit_effect, transform.position, Quaternion.identity);
        Destroy(effect, .5f);
        Destroy(gameObject);
    }
}
