using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetControllerPosition : MonoBehaviour {

	//private Vector3 PositionAdjustment = new Vector3 (-0.35f, -0.41f, -0.61f);
	private Vector3 PositionAdjustment = new Vector3 (0, 0, 0);
	private bool calibrating;
	public GameObject RightController;
	// Use this for initialization
	void Start () {
		calibrating = true;
		//transform.position = RightController.transform.position + PositionAdjustment;
		transform.position = RightController.transform.position;
		transform.rotation = RightController.transform.rotation;

        var Rotation = Quaternion.Euler(0, RightController.transform.rotation.eulerAngles.y, 0); //transpose values
        transform.rotation = Rotation;
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("c"))
		{
			Debug.Log("Table calibrated");
			calibrating = false;
		}

		if(calibrating)
		{
			//transpose values
			var Rotation = Quaternion.Euler(0, RightController.transform.rotation.eulerAngles.y, 0);
        		transform.rotation = Rotation;
			transform.position = RightController.transform.position;
		}
	}

}
