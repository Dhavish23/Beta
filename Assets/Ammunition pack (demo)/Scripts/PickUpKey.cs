using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public AudioClip keyPickupSound; 
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = keyPickupSound;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
       
        audioSource.Play();

        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Destroy the key object after the sound has finished playing
        Destroy(gameObject, keyPickupSound.length);
    }
}
