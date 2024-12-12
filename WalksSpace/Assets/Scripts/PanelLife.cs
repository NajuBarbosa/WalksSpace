using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PanelLife : MonoBehaviour
{
     public Text textoVida;


    void Update()
    {
        this.textoVida.text = (ControladorLife.Vida + "x");
    }
}
