using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float BulletSpeed;

    // Use this for initialization
    void Start () {

        // Set default bullet speed of 6
        if (BulletSpeed == 0)
        {
            BulletSpeed = 6.0f;
        }
	}
	
	// Update is called once per frame
	void Update () {

        Quaternion BulletRotation = gameObject.transform.rotation;

        transform.position -= (transform.up) * Time.deltaTime * BulletSpeed;
    }
}
