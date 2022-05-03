using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Animator myAnimator;
    [SerializeField] float moveSpeed = 1f;
    void Start()
    {
        PrintInstructions();
        myAnimator = gameObject.GetComponent<Animator>();
        myAnimator.SetFloat("Idle",0);
    }


    void Update()
    {
        movePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to WCS, your job is get from point A to point B! Goodluck and have fun!");
        Debug.Log("Move player using W,A,S,D -- Try not to hit walls!");
    }
    void movePlayer()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
    
}