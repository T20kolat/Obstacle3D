using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObs : MonoBehaviour
{
    
    // [SerializeField]float rotationSpeed = 1f;
    // Vector3 euler_Angles;

    [SerializeField] float xAngle,yAngle,zAngle = 0;
    void Update()
    {
        // euler_Angles += new Vector3(0,360,0)* Time.deltaTime * rotationSpeed;
        // transform.eulerAngles = euler_Angles;
        transform.Rotate(xAngle,yAngle,zAngle); // Tried this shit like 5 times without working, mby bug!
    }
    
}
