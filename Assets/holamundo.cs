using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class holamundo : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void holamundofuncion()
    {
        int counter = 0;
        while (counter < 5)
        {
            Debug.Log("Hola mundo");
            counter++;
        }
    }
}
