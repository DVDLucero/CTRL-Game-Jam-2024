using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Optional: Sound or particle effect when collected
    public AudioClip collectSound;
    public GameObject collectEffect;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is the player
        if (other.CompareTag("Player"))
        {
            // Optional: Play sound if there is one
            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, transform.position);
            }

            // Optional: Instantiate a particle effect
            if (collectEffect != null)
            {
                Instantiate(collectEffect, transform.position, Quaternion.identity);
            }

            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}