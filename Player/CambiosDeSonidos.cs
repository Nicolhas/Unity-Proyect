using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiosDeSonidos : MonoBehaviour
{
    public AudioClip clipPasos;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            {
                player.GetComponent<AudioSource>().clip = clipPasos;
            }
        }


    }

}
