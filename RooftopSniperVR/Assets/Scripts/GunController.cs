using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

    // Arduino values to detect reload
    public GameObject ArduinoWatcher;
    public float FromArduino;

    private bool loaded = false;

    // Used to only detect axis
    private bool shootPressed = false;
    private bool reloadPressed = false;

    public GameObject bullet;
    public Vector3 bulletSpawnPoint;
    private Quaternion bulletRotation;

    // Axis value inputs to bools
    private void getAxisInputs()
    {
        if (Input.GetAxis("Shoot") > 0)
        {
            shootPressed = true;
        }
        else
        {
            shootPressed = false;
        }

        if (Input.GetAxis("Reload") > 0)
        {
            reloadPressed = true;
        }
        else
        {
            reloadPressed = false;
        }
    }


    // Reload the gun
    private void reload()
    {
        if (!loaded)
        {
            loaded = true;
            Debug.Log("Reloading");
        } else
        {
            Debug.Log("Gun is already loaded");
        }
    }

    // Spawn bullet and require reload
    private void shoot()
    {
        if (loaded)
        {
            loaded = false;
            Debug.Log("Shooting");
            Instantiate(bullet, bulletSpawnPoint, bulletRotation);
        } else
        {
            Debug.Log("Gun is not loaded");
        }
    }


	void Start () {

        // Check if bullet is attatched to gun
        if (bullet == null)
        {
            Debug.LogError("Bullet GameObject not attatched to gun");
        }

        // Set bullet rotation to match the gun
        bulletRotation = gameObject.transform.rotation;

        // Set bullet spawn to location of spawn on gun object
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        // Get potentiometer value
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;

        getAxisInputs();

        // Detect firing input
        if (shootPressed)
        {
            shoot();
        }
        // Detect reload input
        if (FromArduino > 950)
        {
            reload();
        }

	}
}
