using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public GameObject ArduinoWatcher;
    public float FromArduino;
    public Vector3 positionAdjustment;
    public float sensitivityAdjustment;
    //private float PreviousPotentiometerValue;
    public Vector3 TargetPosition;

    // Use this for initialization
    void Start () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;
        //PreviousPotentiometerValue = FromArduino;
    }
	
	// Update is called once per frame
	void Update () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;
        TargetPosition = new Vector3(0.05f, -0.03f, -0.08f);
        //Move reload in line with potentiometer position
        if (FromArduino % 2 == 0)
        {
            TargetPosition = new Vector3(positionAdjustment.x, positionAdjustment.y, (FromArduino)/ sensitivityAdjustment + positionAdjustment.z);

            gameObject.transform.localPosition -= TargetPosition + gameObject.transform.localPosition;
        }
    }
}
