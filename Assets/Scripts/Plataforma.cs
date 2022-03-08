using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    private Camera camara;
    public GeneradorPlataformas generador;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-speed, rb.velocity.y);

        if(gameObject.transform.position.x < (camara.transform.position.x - 20))
        {
            //generador.Cantidad--;
            gameObject.SetActive(false);
            Destroy(gameObject, 0.5f);
        }
    }
}
