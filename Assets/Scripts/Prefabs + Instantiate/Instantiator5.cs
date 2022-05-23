using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator5 : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubo;
    public GameObject Sphere;

    public Text CualActivo;

    int activo;

    public void boton1()
    {
        activo = 1;
        CualActivo.text = "el prefab 1 está activo";
    }
    public void boton2()
    {
        activo = 2;
        CualActivo.text = "el prefab 2 está activo";
    }
    public void boton3()
    {
        activo = 3;
        CualActivo.text = "el prefab 3 está activo";
    }

    public void botonInstanciar()
    {
        switch (activo)
        {
            case 1:
                GameObject clon;

                clon = Instantiate(cube);
                Destroy(clon, 2);
                break;
            case 2:
                GameObject clon2;

                clon2 = Instantiate(cubo);
                Destroy(clon2, 2);
                break;
            case 3:
                GameObject clon3;

                clon3 = Instantiate(Sphere);
                Destroy(clon3, 2);
                break;
        }
    }
}
