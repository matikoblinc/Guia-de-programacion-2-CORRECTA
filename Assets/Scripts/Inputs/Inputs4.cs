using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs4 : MonoBehaviour
{
    public GameObject cube;
    public float velocidadMov;
    public float Rotacion1;
    Vector3 rotacionDerecha;
    Vector3 rotacionIzquierda;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.position += new Vector3(velocidadMov, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.position -= new Vector3(velocidadMov, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.eulerAngles += new Vector3(0, 0, Rotacion1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.eulerAngles -= new Vector3(0, 0, Rotacion1);
        }
    }
}
