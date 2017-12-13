using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public float bulletSpeed;
    public Rigidbody rb;
    public float selfDestructTimer;

    // Use this for initialization
    void Start () {
        // Destroy self after time
        Object.Destroy(gameObject, selfDestructTimer);

        // Set default bullet speed of 6
        if (bulletSpeed == 0)
        {
            bulletSpeed = 6.0f;
        }

        // Get rigidbody
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // Add forward force
        rb.AddRelativeForce(0, 0, -bulletSpeed);
    }
}
