using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector36 : MonoBehaviour
{
    public GameObject cube;
    public GameObject esfera;
    public GameObject cilindro;
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

                        GameObject clone;
                        clone = Instantiate(esfera);
                        Destroy(clone, 10);
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
                        GameObject clone2;
                        clone2 = Instantiate(cilindro);
                        Destroy(clone2, 10);
                    }
                }
            }
        }
    }
}
