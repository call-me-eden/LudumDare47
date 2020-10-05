using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalExplode : MonoBehaviour
{
    public ParticleSystem exp;
    void Explode()
    {
        //ParticleSystem exp = GetComponent<ParticleSystem>();//get partical system from this object
        exp.Play();//play partical sytem
        //Destroy(gameObject, exp.main.duration);
    }
    // Start is called before the first frame update

    void Start()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)//run function Explode when this object hits another object
    {
        Explode();//run func
    }
    // Update is called once per frame
    void Update()
    {
        //nothing here
    }
}
