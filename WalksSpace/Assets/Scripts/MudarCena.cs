using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public string cena;

    // Update is called once per frame
    public void Game()
    {
        StartCoroutine("PlayCenas");
    }
    IEnumerator PlayCenas()
    {
      yield return new WaitForSeconds(0.5f);
      SceneManager.LoadScene(cena);
    }
}
