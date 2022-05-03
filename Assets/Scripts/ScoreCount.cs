using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    int scoreCount;
    
    
    void OnCollisionEnter(Collision score)
    {
        if (score.gameObject.CompareTag("UnHit")) // if object hasn't been hit it will increment score by 1 !
        {
            scoreCount++;
            Debug.Log("You've hit an obstacle " + scoreCount + " times!");
        }
    }

    
}
