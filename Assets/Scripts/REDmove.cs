using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REDmove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool andando;
    public bool saltando;
    public int vidas = 3;

    bool puedeSaltar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        {
            Move();
            gameObject.GetComponent<Animator>().SetBool("andando", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (Input.GetKey("left"))
        {
            Move();
            gameObject.GetComponent<Animator>().SetBool("andando", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if(!Input.GetKey("right") && !Input.GetKey("left"))
        {
            gameObject.GetComponent<Animator>().SetBool("andando", false);
        }

        if(Input.GetKeyDown(KeyCode.Space) && puedeSaltar)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            puedeSaltar = false;
            gameObject.GetComponent<Animator>().SetBool("saltando", true);
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1200f));
        }
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = speed * x;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "suelo")
        {
            gameObject.GetComponent<Animator>().SetBool("saltando", false);
            puedeSaltar = true;
        }

        if(collision.transform.tag == "Enemigo")
        {
            vidas--;
            Debug.Log(vidas);
        }
    }

}
