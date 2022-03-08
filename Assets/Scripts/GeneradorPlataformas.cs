using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPlataformas : MonoBehaviour
{
    public GameObject plataforma;
    public float probabilidad;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        generaPlataforma();
    }

    public void generaPlataforma()
    {
        float numero = Random.Range(0.0f, probabilidad);
        if (numero < 1.0f)
        {
            GameObject.Instantiate(plataforma, transform.position, transform.rotation);
        }
    }
}
