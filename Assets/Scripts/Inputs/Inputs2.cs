using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs2 : MonoBehaviour
{
    public GameObject textoActivo;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textoActivo.SetActive(!textoActivo.activeInHierarchy);
        }
    }
}
