using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoWatcherScript : MonoBehaviour {

    SerialPort ArduinoPort = new SerialPort("COM3", 9600);

    // value accessed by other scripts
    public float PotentiometerValue;

    private string OutputFromArduino;

    // Used to split arduino string for sanity check
    private int CorrectPotentiometerLength;
    private string PotentiometerString;

    void Start()
    {
        ArduinoPort.Open();
        ArduinoPort.ReadTimeout = 1;
    }

    void Update()
    {
        if (ArduinoPort.IsOpen)
            try
            {
                OutputFromArduino = ArduinoPort.ReadLine();

                // Get the first number in arduino output for sanity checking
                CorrectPotentiometerLength = int.Parse(OutputFromArduino.Substring(0, 1));

                // Get rest of the arduino output as potentiometer value
                PotentiometerString = OutputFromArduino.Substring(1, (OutputFromArduino.Length - 1));

                // Check if potentiometer length matches what it should be
                if (CorrectPotentiometerLength == PotentiometerString.Length)
                {
                    // Output if value is correct
                    PotentiometerValue = float.Parse(PotentiometerString);
                }
            }
            catch (System.Exception)
            {

            }
    }
}
