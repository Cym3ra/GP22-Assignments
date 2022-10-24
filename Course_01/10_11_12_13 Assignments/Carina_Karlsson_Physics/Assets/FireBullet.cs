using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform gun;
    [SerializeField] AudioClip fireBullet;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, gun.position, gun.rotation);
            GetComponent<AudioSource>().PlayOneShot(fireBullet);
        }
    }
}
