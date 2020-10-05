using UnityEngine;
using System.Collections;
public class ParralaxTest : MonoBehaviour
{
    public GameObject self;
    public GameObject cameraY;
    public float ParralaxDepth;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        self.transform.position = new Vector3((cameraY.transform.position.x / ParralaxDepth), (cameraY.transform.position.y/ParralaxDepth), ParralaxDepth);
    }
}