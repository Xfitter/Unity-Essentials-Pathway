using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float Rotation_Speed;
    public GameObject onCollectEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {transform.Rotate(0,Rotation_Speed,0);
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        //Destroy the collectible 
        if(other.CompareTag("Player")){
        Destroy(gameObject);
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
