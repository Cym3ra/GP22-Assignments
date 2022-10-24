using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneratorScript : MonoBehaviour
{
    [SerializeField] GameObject[] clouds;
    [SerializeField] GameObject endPoint;

    float spawnInterval = 5f;
    Vector3 startPos;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        Prewarm();
        Invoke("AttemptSpawn", spawnInterval);
    }

    private void SpawnCloud(Vector3 startPos)
    {
        GameObject cloud = Instantiate(clouds[Random.Range(0, clouds.Length)]);

        float startY = Random.Range(startPos.y - 1f, startPos.y + 1f);

        cloud.transform.position = new Vector3(startPos.x, startY, startPos.z);

        float cloudScale = Random.Range(0.8f, 1.2f);
        cloud.transform.localScale = new Vector2(cloudScale, cloudScale);

        float windSpeed = Random.Range(0.3f, 1f);
        cloud.GetComponent<CloudScript>().StartFloating(windSpeed, endPoint.transform.position.x);

    }

    void AttemptSpawn()
    {
        SpawnCloud(startPos);
        Invoke("AttemptSpawn", spawnInterval);
    }

    void Prewarm()
    {
        for (int i = 0; i < 6; i++)
        {
            Vector3 spawnPos = startPos + Vector3.right * (i * 2);
            SpawnCloud(spawnPos);
        }
    }
}
