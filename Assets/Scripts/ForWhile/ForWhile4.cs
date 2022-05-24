using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForWhile4 : MonoBehaviour
{

    public Text numeroDerecha;
    public Text numeroIzquierda;


    // Start is called before the first frame update
    public void button1()
    {
        int derecha = int.Parse(numeroDerecha.text);
        int izquierda = int.Parse(numeroIzquierda.text);

        if (derecha == izquierda)
        {
            Debug.Log("los numeros son iguales");
        }
        else if (derecha > izquierda)
        {
            izquierda++;
            for (int i = izquierda; i < derecha; i++)
            {
                Debug.Log(i);
            }
        }
        else
        {
            izquierda--;
            for (int i = izquierda; i > derecha; i--)
            {
                Debug.Log(i);
            }
        }

    }
}

