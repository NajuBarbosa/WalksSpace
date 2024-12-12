using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject optionsPanel;

    public void ShowOptions () 
    {

        optionsPanel.SetActive(true);
        
    }

    public void HideOptions () 
    {

        optionsPanel.SetActive(false);
        
    }
}
