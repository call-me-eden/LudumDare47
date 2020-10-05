using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource se1;//sound effct 1 audio import
    void Start()
    {
        //source = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // play the sound

        se1.Play();
    }
}