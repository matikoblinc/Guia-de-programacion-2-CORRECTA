using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs3 : MonoBehaviour
{
    public float num1;

    void Update()
    {
       if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, num1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, num1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(num1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(num1, 0, 0);
        }
    }
}
