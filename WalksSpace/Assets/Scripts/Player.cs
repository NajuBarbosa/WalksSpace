using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject tiro;
    public GameObject morre;
     public GameObject player;
    public string cena;
    //public int vidas;
    public GameObject explode;

    void Start() 
    {
       ControladorLife.Vida = 3;
       ControladorPontuacao.Pontuacao = 0;
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Asteroid"))
        {
          ControladorLife.Vida--;
          Vector3 pos = col.transform.position;
          GameObject clone = (GameObject)Instantiate (explode, pos, Quaternion.identity);

           GameObject.Destroy(col.gameObject);
           GameObject.Destroy(clone, 0.09f);
          
        }

        if(ControladorLife.Vida <= 0)
        {
            StartCoroutine("morte");
        } 
    }
    IEnumerator morte()
    {
      yield return new WaitForSeconds(0.3f);
      Destroy (player);
      SceneManager.LoadScene(cena);
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          Vector3 pos = this.transform.position;
          Instantiate(tiro,pos,Quaternion.Euler(0,0,0));
        }
    }
}
