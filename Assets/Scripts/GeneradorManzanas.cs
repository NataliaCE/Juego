using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorManzanas : MonoBehaviour
{
    public GameObject manzana;
    public float probabilidad;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= 1f)
        {
            generaManzana();
        }
    }

    public void generaManzana()
    {
        timer = 0;

        float numero = Random.Range(0.0f, probabilidad);
        float y = Random.Range(-4f, 2f);
        Vector3 posicion = new Vector3(transform.position.x, y, transform.position.z);
        if (numero < 1.0f)
        {
            GameObject.Instantiate(manzana, posicion, transform.rotation);
        }
    }
}
