using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFields4 : MonoBehaviour
{
    public Text InputField1;
    public Text InputField2;
    public Text texto;
    int num1;
    int num12;
    int num123;
    string num2;

    public void boton1()
    {
        if (InputField1.text == "" || InputField2.text == "")
        {
            texto.text = "Llene bos InputFields con algún numero";
        }
        else
        {
            num1 = int.Parse(InputField1.text);
            num12 = int.Parse(InputField2.text);

            if (num12 == 0)
            {
                texto.text = "No se puede dividir por cero";
            }
            else
            {
                num123 = num1 / num12;

                num2 = num123.ToString();
                texto.text = num2;
            }
        }
       
        
    }
}
