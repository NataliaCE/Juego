using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPlataformas : MonoBehaviour
{
    public GameObject plataforma;
    public float probabilidad;
    public int maximo;
    private int cantidad;

    public int Cantidad
    {
        get { return cantidad; }
        set { maximo = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        cantidad = 0;
    }

    // Update is called once per frame
    void Update()
    {
        generaPlataforma();
    }

    public void generaPlataforma()
    {
        float numero = Random.Range(0.0f, probabilidad);
        if (numero < 1.0f && cantidad < maximo)
        {
            GameObject.Instantiate(plataforma, transform.position, transform.rotation);
            cantidad++;
        }
    }
}
