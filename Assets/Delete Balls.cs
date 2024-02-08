using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.SetActive(false);
    }
}
