using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    [SerializeField] Animator animacion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Move();
        }
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = speed * x;
        animacion.SetFloat("Direccion", x);
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }
}
