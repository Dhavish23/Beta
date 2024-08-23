using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;
    
    private void Start()
    {
       source = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    private void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))   
     {
        source.PlayOneShot(clip);
     }
    }
}
