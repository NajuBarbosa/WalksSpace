using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public GameObject explode;
    public GameObject destroir;

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.name.StartsWith("Asteroid"))
        {
            ControladorPontuacao.Pontuacao++;
            Vector3 pos = col.transform.position;
            GameObject clone = (GameObject)Instantiate (explode, pos, Quaternion.identity);

           GameObject.Destroy(col.gameObject);
           GameObject.Destroy(this.gameObject);
           GameObject.Destroy(clone, 0.09f);

        }

        if(col.CompareTag("Destruir"))
        {
           Destroy (gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
