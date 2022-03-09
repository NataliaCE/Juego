using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    public GeneradorEnemigos generadorLobos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemigo")
        {
            generadorLobos.cantidad--;
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject, 0.5f);
        } 
    }
}
