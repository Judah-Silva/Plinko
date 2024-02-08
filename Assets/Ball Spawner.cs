using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnTransform;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float r = (Random.value * 20) - 5;
        Debug.Log(r);

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 spawnPoint = spawnTransform.position;
            spawnPoint.x = r;

            Instantiate(ballPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
