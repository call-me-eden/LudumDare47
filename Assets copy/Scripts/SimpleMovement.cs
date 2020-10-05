using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleMovement : MonoBehaviour
{
    public Rigidbody2D r2d;
    public float jumpHeight;

    float horizontal;

    public float maxSpeed;

    public Rigidbody2D body;

    public bool oneJump = false;

    public CapsuleCollider2D collider;

    GameObject[] platforms;

    public bool falling = false;

    public GameObject player;

    public GameObject camera;

    bool canFall = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        platforms = GameObject.FindGameObjectsWithTag("platform");

        if (!falling)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
        }

        if (Input.GetKeyDown(KeyCode.Space) && !oneJump)
        {
            body.velocity = new Vector2(body.velocity.x, jumpHeight);
            oneJump = true;
        }

        if(horizontal <= -1)
        {
            transform.localScale = new Vector3(-6.3029f, transform.localScale.y);
        }
        if(horizontal >= 1)
        {
            transform.localScale = new Vector3(6.3029f, transform.localScale.y);
        }

        

    }

    private void FixedUpdate()
    {
        if (!falling)
        {
            body.velocity = new Vector2(horizontal * maxSpeed, body.velocity.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        

        Debug.Log(col.name);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        oneJump = false;

        if (collision.collider.tag == "Fall Bro" && canFall)
        {
            body.velocity = new Vector2(0, 0);
            canFall = false;
            falling = true;
            Debug.Log("HAHAHA");
            
            body.transform.position = new Vector3(-2.15f, transform.position.y);


        }
    }
}
