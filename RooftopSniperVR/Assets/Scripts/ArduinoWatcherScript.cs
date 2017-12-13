using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoWatcherScript : MonoBehaviour {

    SerialPort ArduinoPort = new SerialPort("COM3", 9600);

    // value accessed by other scripts
    public float potentiometerValue;

    public string outputFromArduino;

    public float outputFrequency;

    public float counter;
    public float tick;

    // Used to split arduino string for sanity check
    private int CorrectPotentiometerLength;
    private string potentiometerString;

    void Start()
    {
        ArduinoPort.Open();
        ArduinoPort.ReadTimeout = 1;
    }

    void Update()
    {
        tick += 1;

        if (ArduinoPort.IsOpen)
            try
            {
                outputFromArduino = ArduinoPort.ReadLine();
                potentiometerValue = float.Parse(outputFromArduino);

            }
            catch (System.Exception)
            {

            }

        if (potentiometerValue == 1)
        {
            counter += 1;
        }

        if(tick == 100)
        {
            outputFrequency = counter / tick;
            counter = 0;
            tick = 0;
        }

        potentiometerValue = 0;
    }
}
