using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForWhile3 : MonoBehaviour
{
    public Text text1;
    public Text text2;
 

    // Start is called before the first frame update
    public void button1()
    {
       int num1 = int.Parse(text1.text);
       int num2 = int.Parse(text2.text);

        if (num1 == num2)
        {
            Debug.Log("los numeros son iguales");
        }
        else if (num1 > num2)
        {
            while (num1 > num2)
            {
                num2++;
                Debug.Log(num2);
            }
        }
        else
        {
            while (num1 < num2)
            {
                num2--;
                Debug.Log(num2);
            }
        }

    } 
    


}
