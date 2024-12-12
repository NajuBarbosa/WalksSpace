using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControladorLife 
{

    private static int vidas;
    public static int Vida  
    {
      get
        {
           return vidas;
        }

        set 
        {
            vidas = value;
            if(vidas < 0 ) 
            {
                vidas = 0;
            } 
        }
    }
}
