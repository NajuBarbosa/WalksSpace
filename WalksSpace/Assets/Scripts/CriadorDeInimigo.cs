using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriadorDeInimigo : MonoBehaviour
{
    public GameObject [] naves;
    public Vector3 range;
    public float tempo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Create",0 , tempo);
    }

    void Create()
    {
        GameObject nave = naves [Random.Range(0, naves.Length)];
        Vector3 pos = this.transform.position + Vector3.Lerp(-range, range, Random.value);
        Instantiate(nave, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


}
