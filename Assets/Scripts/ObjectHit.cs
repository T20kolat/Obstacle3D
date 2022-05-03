using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    

       private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) // Checking if the collision hits with tag "Player" !!
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit"; // Changing objects tag to Hit after collision!
        }
        // On hit with the wall -> we change color to Red!
    }
}
