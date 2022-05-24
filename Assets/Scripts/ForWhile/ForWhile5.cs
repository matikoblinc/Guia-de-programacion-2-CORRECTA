using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForWhile5 : MonoBehaviour
{
    public GameObject cube;
    public Text cantidad1;
    public Text cantidad;
    int cantidadVeces;

    public void botonCantInst()
    {
        if (cantidad.text == "")
        {
            cantidad1.text = "debe ingresar un numero";
        }
        else
        {
            cantidadVeces = int.Parse(cantidad.text);
            if (cantidadVeces > 0)
            {
                for (int i = 0; i < cantidadVeces; i++)
                {
                    Instantiate(cube);
                }
            }
            else
            {
                Debug.Log("el numero debe ser mayor a cero");
            }
        }
    }
}
