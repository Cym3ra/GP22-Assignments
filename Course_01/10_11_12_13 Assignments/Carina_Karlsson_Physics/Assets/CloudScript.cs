using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    // Start is called before the first frame update

    private float cloudSpeed = 0.5f;
    private float endPositionX;



    void Update()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * cloudSpeed));

        if (transform.position.x > endPositionX)
        {
            Destroy(gameObject);
        }
    }

    public void StartFloating(float speed, float endPosX)
    {
        cloudSpeed = speed;
        endPositionX = endPosX;
    }
}
