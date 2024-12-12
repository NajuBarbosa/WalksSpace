using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PanelPontu : MonoBehaviour
{

    public Text textoPontuacao;


    void Update()
    {
        this.textoPontuacao.text = (ControladorPontuacao.Pontuacao + "X");
    }
}
