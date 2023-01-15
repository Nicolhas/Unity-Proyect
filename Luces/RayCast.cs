using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public int rango;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rango))
        {

            if (hit.collider.GetComponent<Interruptor>() == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.collider.GetComponent<Interruptor>().luz == true)
                    {
                        hit.collider.GetComponent<Interruptor>().OnOffLuz();
                    }


                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * rango);

    }

}
