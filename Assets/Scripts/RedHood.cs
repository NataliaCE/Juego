using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedHood : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool andando;
    public bool saltando;
    private int vidas;
    private bool salta;
    public float gravedadNormal;
    public float gravedadCaida;

    public int Vidas
    {
        get { return vidas; }
        set { vidas = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vidas = 20;
        salta = false;
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

        if(Input.GetKeyDown(KeyCode.Space) && !salta)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            gameObject.GetComponent<Animator>().SetBool("saltando", true);
            salta = true;
        }

        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = gravedadNormal;
        } 
        else if(rb.velocity.y < 0)
        {
            rb.gravityScale = gravedadCaida;
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
        if(collision.transform.tag == "suelo" || collision.transform.tag == "Plataforma")
        {
            salta = false;
            gameObject.GetComponent<Animator>().SetBool("saltando", false);
        }

        if(collision.transform.tag == "Enemigo")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            vidas--;
            if(vidas <= 0)
            {
                gameObject.SetActive(false);
                SceneManager.LoadScene("Muerte");
            }
        }

        if(collision.transform.tag == "Hueco")
        {
            vidas = 0;
            gameObject.SetActive(false);
            SceneManager.LoadScene("Muerte");
        }
    }

}
