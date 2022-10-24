using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] AudioClip bulletHit;
    PlayerPlatformController player;
    private float bulletSpeed = 12f;
    private float xSpeed;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerPlatformController>();


        if (player.transform.localScale.x < 0)
        {
            bulletSpeed = -bulletSpeed;
        }
    }

    void Update()
    {
        rb2D.velocity = new Vector2(bulletSpeed, rb2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            GetComponent<AudioSource>().PlayOneShot(bulletHit);
            Destroy(gameObject, 0.2f);
        }
    }
}
