using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System;

public class Joystick : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM6", 9600);
    public string receivedstring;
    public float xVal;
    public float yVal;
    void Start()
    {
        stream.Open();
        print("hello");
        xVal = 0;
        yVal = 0;
    }

    void Update()
    {     
        receivedstring = stream.ReadLine();
        stream.BaseStream.Flush();
        xVal = 0;
        yVal = 0;

        if (receivedstring == "UP"){
            yVal = 1;
        }else if(receivedstring == "DOWN"){
            yVal = -1;
        }

        if (receivedstring == "RIGHT"){
            xVal = 1;
        }else if(receivedstring == "LEFT"){
            xVal = -1;
        }


        // print(receivedstring);
   
    }
}
