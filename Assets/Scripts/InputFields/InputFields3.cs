using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFields3 : MonoBehaviour
{
    public Text InputField1;
    public Text texto;
    int num1;
    string num2;

    public void boton1()
    {
        if (InputField1.text != "")
        {
            num1 = int.Parse(InputField1.text);
            num1 *= num1;

            num2 = num1.ToString();
            texto.text = num2;
        }
        else
        {
            Debug.Log("el mensaje es nulo");
        }
    }
}
