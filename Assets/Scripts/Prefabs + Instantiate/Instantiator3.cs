using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator3 : MonoBehaviour
{
    public GameObject cubo;
    int num1 = 0;

    public void boton1()
    {
        if (num1 == 0)
        {
            Instantiate(cubo);
            num1++;
        }
        else
        {
            Debug.Log("instancia ya creada");
        }
    }
}
