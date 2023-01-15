using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Este script nos sirve como ejemplo para interactuar con objetos, en este caso luces de una casa
public class Interruptor : MonoBehaviour
{

    public GameObject luzObjeto;

    public bool luz;

    private bool luzOnOff;

    public void OnOffLuz()
    {
        luzOnOff = !luzOnOff;

        if(luzOnOff == true)
        {
            luzObjeto.SetActive(true);

        }

        if (luzOnOff == false)
        {
            luzObjeto.SetActive(false);

        }
    }

}
