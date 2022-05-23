using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector31 : MonoBehaviour
{
    public GameObject cube;
    public float movementX;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.position += new Vector3 (movementX, 0, 0);
        }
    }
}
