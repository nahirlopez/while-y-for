﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuemeroentero : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        if(num1>=num2)
        {
            Debug.Log("Error");
        }
        else
        {
while (num2 >=num1)
        {
                Debug.Log(num2);
                num2--;
        }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
