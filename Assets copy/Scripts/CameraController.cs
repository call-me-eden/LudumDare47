using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;


public class CameraController : MonoBehaviour
{
    public GameObject player;
    float x;
    public float smoothing;
    public float playerY;

    public SimpleMovement characterController;

    public GameObject cameraCol;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;

        transform.position = new Vector3((transform.position.x + ((player.transform.position.x - transform.position.x) / smoothing)), (transform.position.y + ((player.transform.position.y - transform.position.y)/smoothing)), -10);

        //(transform.position.x + ((player.transform.position.x - transform.position.x) / smoothing))
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "floor" && characterController.falling == true)
        {
            characterController.falling = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}