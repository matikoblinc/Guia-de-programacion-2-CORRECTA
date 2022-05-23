using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector33 : MonoBehaviour
{
    public GameObject cube;
    public float movementX;
    public float MovimientoMax;

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
                    }
                }

            }
            else if (llego == true)
            {
                cube.transform.position += new Vector3(-movementX, 0, 0);
            }
        }
    }
}
