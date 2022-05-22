using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForWhile4 : MonoBehaviour
{

    public Text text1;
    public Text text2;

    public void button1()
    {
        int num1 = int.Parse(text1.text);
        int num2 = int.Parse(text2.text);

        if (num1 == num2)
        {
            Debug.Log("los numeros son iguales");
        }
        if (num1 < num2)
        {
            for (int i = num1; i < num2; i++)
            {
                Debug.Log(i);
            }

        }

        else if (num1 > num2)
        {
            for (int i = num1; i > num2; i--)
            {
                Debug.Log(i);
            }
        }

    }
}
