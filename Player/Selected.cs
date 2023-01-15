using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    public float distancia = 1.5f;

    public int rango;
    public Camera camara;
    public GameObject brazoConLinterna;
    public GameObject Linterna;
    public GameObject Jeringa;
    public GameObject brazoConJeringa;
        
    private bool activo;

  
    LayerMask mask;


    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia, mask))
        {
            if (hit.collider.tag == "Objeto Interactivo")

            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Objeto>().ActivarObjeto();


                }
            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distancia, Color.red);

            if (hit.collider.tag == "Door") ;
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<DoorSystem>().ChangeDoorState();

                }
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                if (hit.collider.CompareTag("Linterna"))
                {
                    brazoConLinterna.SetActive(true);
                    Destroy(Linterna);
                }
                else
                {
                    brazoConLinterna.SetActive(false);
                    //Código para droppear la linterna
                    
                }
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                if (hit.collider.CompareTag("Jeringa"))
                {
                    brazoConJeringa.SetActive(true);
                    Destroy(Jeringa);
                }
                else
                {
                    brazoConJeringa.SetActive(false);
                    //Código para droppear la linterna

                }

            }
        }
    }
}

