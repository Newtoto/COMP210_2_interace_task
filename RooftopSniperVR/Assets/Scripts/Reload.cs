using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public GameObject ArduinoWatcher;
    public float FromArduino;
    //private float PreviousPotentiometerValue;
    public Vector3 TargetPosition;

    float MinArduinoValue = 70; // Only accept values above 70 to avoid most value jumping

    // Use this for initialization
    void Start () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;
        //PreviousPotentiometerValue = FromArduino;
    }
	
	// Update is called once per frame
	void Update () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;

        if (FromArduino % 2 == 0 && FromArduino > MinArduinoValue)
        {
            TargetPosition = new Vector3(0.0f, 0.0f, FromArduino / 8000);

            gameObject.transform.localPosition -= TargetPosition + gameObject.transform.localPosition;
        }

        //PreviousPotentiometerValue = FromArduino;
    }
}
