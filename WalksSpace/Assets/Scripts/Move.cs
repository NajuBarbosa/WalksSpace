using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Destruir"))
        {
           Destroy (gameObject);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        Rigidbody2D r = this.GetComponent<Rigidbody2D>();
        r.velocity = new Vector3(h,0,0) * speed;
    }
}
