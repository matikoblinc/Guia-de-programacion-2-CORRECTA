using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFields2 : MonoBehaviour
{
    public Text InputField1;
    public Text texto;

    public void boton1()
    {
        if (InputField1.text != "")
        {
            texto.text = InputField1.text;
        }
        else
        {
            Debug.Log("el mensaje es nulo");
        }
    }
}
