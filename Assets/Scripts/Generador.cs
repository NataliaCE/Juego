using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject enemigo;
    public float probabilidad;
    public int cantidad = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreaEnemigo();
    }

    private void CreaEnemigo()
    {
        if(cantidad == 0)
        {
            GameObject.Instantiate(enemigo, transform.position, transform.rotation);
            cantidad++;

        } 
        else
        {
            float numero = Random.Range(0.0f, probabilidad);
            if (numero < 1.0f && cantidad < 3)
            {
                GameObject.Instantiate(enemigo, transform.position, transform.rotation);
                cantidad++;
                Debug.Log("Lobos: " + cantidad);
            }
        }
    }
}
