using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoWatcherScript : MonoBehaviour {

    SerialPort ArduinoPort = new SerialPort("COM3", 9600);
    public int potentiometerValue;

    // Use this for initialization
    void Start()
    {
        ArduinoPort.Open();
        ArduinoPort.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (ArduinoPort.IsOpen)
            try
            {
                potentiometerValue = int.Parse(ArduinoPort.ReadLine());
            }
            catch (System.Exception)
            {

            }
    }
}
