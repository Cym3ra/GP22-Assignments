using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    PlayerPlatformController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponentInParent<PlayerPlatformController>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        
    }
}
