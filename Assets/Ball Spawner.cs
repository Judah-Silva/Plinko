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
        float r = (Random.value * 17.5f) - 2;
        // Debug.Log(r);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPoint = new Vector3(r, spawnTransform.position.y, spawnTransform.position.z);
            
            Instantiate(ballPrefab, spawnPoint, Quaternion.identity);
        }
    }
}
