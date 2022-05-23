using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector32 : MonoBehaviour
{
    public GameObject cube;
    public float movementX;
    public float MovimientoMax;

    void Update()
    {
        if (cube.transform.position.x < MovimientoMax)
        {
            if (Input.GetKey(KeyCode.D))
            {
                cube.transform.position += new Vector3(movementX, 0, 0);
            }
        }
    }
}
