using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton4 : MonoBehaviour
{
    public GameObject InputField;

    public void boton1()
    {
        InputField.SetActive(!InputField.activeInHierarchy);
    }
}
