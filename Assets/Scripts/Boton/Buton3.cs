using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buton3 : MonoBehaviour
{
    public string Escribi;
    public Text texto;

    public void boton()
    {
        texto.text = Escribi;
    }
}
