using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;


public class ArduinoWatcherScript : MonoBehaviour {

    [SerializeField]
    private InputField COMPortInput;

    private bool portSubmitted;

    SerialPort ArduinoPort;

    // value accessed by other scripts
    public float potentiometerValue;

    public string outputFromArduino;

    // Used to split arduino string for sanity check
    private int CorrectPotentiometerLength;
    private string potentiometerString;

    public void GetPortFromUser()
    {
        // Open port
        ArduinoPort = new SerialPort(COMPortInput.text, 9600);
        ArduinoPort.Open();
        ArduinoPort.ReadTimeout = 1;
        portSubmitted = true;

        // Disable canvas to make UI disappear
        COMPortInput.GetComponentInParent<Canvas>().enabled = false;
    }

    void Start()
    {
        portSubmitted = false;
        //ArduinoPort = new SerialPort("COM3", 9600);
        //ArduinoPort.Open();
        //ArduinoPort.ReadTimeout = 1;
    }

    void Update()
    {
        if (portSubmitted)
        {
            if (ArduinoPort.IsOpen)
                try
                {
                    outputFromArduino = ArduinoPort.ReadLine();
                    potentiometerValue = float.Parse(outputFromArduino);

                }
                catch (System.Exception)
                {

                }
        }

        // Open COM port input field
        if (Input.GetKeyDown("c"))
        {
            COMPortInput.GetComponentInParent<Canvas>().enabled = true;
        }
    }
}
