using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector35 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubo;
    public float movementX;
    public float MovimientoMax;
    public float MovimientoMin;

    bool llego = false;

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            if (llego == false)
            {
                if (cube.transform.position.x <= MovimientoMax)
                {
                    cube.transform.position += new Vector3(movementX, 0, 0);

                    if (cube.transform.position.x == MovimientoMax)
                    {
                        llego = true;
                        Instantiate(cubo);
                    }
                }

            }
            else if (llego == true)
            {
                if (cube.transform.position.x >= MovimientoMin)
                {
                    cube.transform.position -= new Vector3(movementX, 0, 0);

                    if (cube.transform.position.x == MovimientoMin)
                    {
                        llego = false;
                        Instantiate(cubo);
                    }
                }
            }
        }
    }
}
