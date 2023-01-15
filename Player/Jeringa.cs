using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeringa : MonoBehaviour
{
    public GameObject jeringa1;
    public GameObject brazoConJeringa;
    private bool jeringamano = false;

    public void active()
    {
        jeringamano = !jeringamano;
    }

    void start()
    {
        if (jeringamano == true)
        {
            brazoConJeringa.SetActive(true);
        }

        if (jeringamano == false)
        {
            brazoConJeringa.SetActive(false);

        }
    }
}