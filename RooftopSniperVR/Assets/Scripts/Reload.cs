using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public GameObject ArduinoWatcher;
    public float FromArduino;
    //private float PreviousPotentiometerValue;
    public Vector3 TargetPosition;

    // Use this for initialization
    void Start () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().PotentiometerValue;
        //PreviousPotentiometerValue = FromArduino;
    }
	
	// Update is called once per frame
	void Update () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().PotentiometerValue;
        TargetPosition = new Vector3(0.05f, -0.03f, -0.08f);
        // Move reload in line with potentiometer position
        //if (FromArduino % 2 == 0)
        //{
        //    TargetPosition = new Vector3(0.051f, -0.015f, -0.079f + (FromArduino / 8000));

        //    gameObject.transform.localPosition -= TargetPosition + gameObject.transform.localPosition;
        //}

        //PreviousPotentiometerValue = FromArduino;
    }
}
