using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSuelo : MonoBehaviour
{
    public float tamSuelo;
    

    private Camera camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = (camara.transform.position.x + 20) - transform.position.x;
        if(tamSuelo <= distancia)
        {
            transform.position = new Vector3(camara.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
