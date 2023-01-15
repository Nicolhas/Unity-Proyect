using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaPick : MonoBehaviour
{
    public GameObject brazo1;
    public GameObject brazoConLinterna;
    private bool manostate = false;

    public void active()
    {
        manostate = !manostate;
    }

    void start()
    {
        if (manostate == true) 
        {
            brazoConLinterna.SetActive(true);
        }

        if (manostate == false)
        {
            brazoConLinterna.SetActive(false);

        }
    }
}
