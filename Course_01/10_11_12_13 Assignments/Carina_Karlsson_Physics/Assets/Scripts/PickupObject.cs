using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField] int pointsForPickup = 10;
    [SerializeField] AudioClip pickupSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreText>().AddToScore(pointsForPickup);
            GetComponent<AudioSource>().PlayOneShot(pickupSound);
            Destroy(gameObject, 0.2f);
        }
    }
}
