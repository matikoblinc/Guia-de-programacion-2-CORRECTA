using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cubo;

    public void boton1()
    {
        Instantiate(cubo);
    }
}
