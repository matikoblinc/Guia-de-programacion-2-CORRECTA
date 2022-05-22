using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiateCube : MonoBehaviour
{
    public GameObject cube;
    public Text txtcantidad;
    int cantidad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiatro()
    {
        int steps1 = 0;
        cantidad = int.Parse(txtcantidad.text);
        if (cantidad < 0)
        {
            Debug.Log("no puede instanciar un objeto una cantidad de veces negativa");
        }
        else if (cantidad == 0)
        {
            GameObject clone;
            clone = Instantiate(cube);
            clone.transform.position = new Vector3(steps1, 0, 0);
            steps1++;

        }
        else if (cantidad > 0)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                GameObject clone;
                clone = Instantiate(cube);
                clone.transform.position = new Vector3(steps1, 0, 0);
                steps1+=2;
            }
        }       
    }
}
