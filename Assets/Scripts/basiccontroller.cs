﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basiccontroller : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Horizontal Input=" + Input.GetAxis("Horizontal"));
    }
}
