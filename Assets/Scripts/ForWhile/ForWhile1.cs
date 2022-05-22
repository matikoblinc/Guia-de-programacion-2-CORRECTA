using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForWhile1 : MonoBehaviour
{
    int i = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        while (i < 100)
        {
            Debug.Log(i);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
