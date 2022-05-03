using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   
    MeshRenderer myRenderer; // Caching renderer!
    Rigidbody myRB; // Cache Rigidbody!
    [SerializeField] float timeToWait;

     void Start() 
    {
        myRB = GetComponent<Rigidbody>();
        myRenderer = GetComponent<MeshRenderer>(); 
        myRenderer.enabled = false;
        myRB.useGravity = false;
    }
    
    void Update()
    {
       if(Time.time > timeToWait){
           myRB.useGravity = true;
           myRenderer.enabled = true;
       }
    }

    
}
