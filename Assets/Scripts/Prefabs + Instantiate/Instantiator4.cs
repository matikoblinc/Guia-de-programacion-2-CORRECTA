using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator4 : MonoBehaviour
{
    public GameObject cube;
    public Text cantidadInstanciar;
    public Text cantidadRestante;
    int CantidadMaxima;
    int cantidad;
    int cantidad1;
    int cantidad2 = 0;

    public void InstanciarLimitado()
    {
        if (cantidadInstanciar.text == "")
        {
            cantidadRestante.text = "debe ingresar un numero mayor a 0";
        }
        else
        {
            CantidadMaxima = int.Parse(cantidadInstanciar.text);
            cantidad1 = CantidadMaxima;
            cantidad1 = cantidad1 - cantidad2;
            cantidad1--;

            if (cantidad < CantidadMaxima)
            {
                Instantiate(cube);
                cantidad++;
                cantidad2++;
                cantidadRestante.text = cantidad1.ToString();
            }
            else if (cantidad == CantidadMaxima)
            {
                cantidadRestante.text = "Ya no puede instanciar mas";
            }
        }
    }
}
