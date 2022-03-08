using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour
{
    private Camera camara;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < (camara.transform.position.x - 20))
        {
            //generador.Cantidad--;
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
        }
    }
}
