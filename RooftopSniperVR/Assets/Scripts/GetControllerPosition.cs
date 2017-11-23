using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetControllerPosition : MonoBehaviour {

	//private Vector3 PositionAdjustment = new Vector3 (-0.35f, -0.41f, -0.61f);
	private Vector3 PositionAdjustment = new Vector3 (0, 0, 0);
	public GameObject RightController;
	// Use this for initialization
	void Start () {
		transform.position = RightController.transform.position + PositionAdjustment;
		transform.rotation = RightController.transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		var Rotation = Quaternion.Euler(0, RightController.transform.rotation.eulerAngles.y, 0); //transpose values
		transform.rotation = Rotation;
	}

}
