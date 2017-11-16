using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

    public GameObject ArduinoWatcher;
    public int FromArduino;
    public Vector3 TargetPosition;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;

        TargetPosition = new Vector3(0.0f, 0.0f, FromArduino / 10);

        gameObject.transform.position += TargetPosition - gameObject.transform.position;
    }
}
