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
        Debug.Log(" tama�o : ");
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distTemp = camara.transform.position.x * (1 - efectoParallax); // Cuanto se ha movido el objeto en relaci�n a la c�mara
        float distancia = (camara.transform.position.x * efectoParallax);

        transform.position = new Vector3(posicion + distancia, transform.position.y, transform.position.z);

        if(transform.tag == "Background")
        {
            if (distTemp > posicion + tamanyo)
            {
                posicion += tamanyo;
            }
            else if (distTemp < posicion - tamanyo)
            {
                posicion -= tamanyo;
            }
        }
    }
}
