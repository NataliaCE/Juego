using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoFondo : MonoBehaviour
{
    private float tamanyo, posicion;
    public GameObject camara;
    public float efectoParallax;

    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position.x; //Posicion al comienzo
        tamanyo = GetComponent<SpriteRenderer>().bounds.size.x; //Longitud de sprite

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distancia = (camara.transform.position.x * efectoParallax);
        transform.position = new Vector3(posicion + distancia, transform.position.y, transform.position.z);
    }
}
