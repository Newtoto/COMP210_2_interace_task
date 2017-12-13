using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour {

    // Arduino values to detect reload
    public GameObject ArduinoWatcher;
    public float FromArduino;
    public AudioSource reloadBackSound, reloadForwardSound, shootSound;

    // Vive tracker variables
    private SteamVR_TrackedObject trackedObject;
    public bool trigger;
    public bool reloader;

    private bool loaded = false;

    // Used to only detect axis
    private bool shootPressed = false;

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
    }


    // Reload the gun
    private void reload()
    {
        if (!loaded)
        {
            loaded = true;
            reloadBackSound.Play();
            Debug.Log("Reloading");
        }
        else
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
            shootSound.Play();
        }
        else
        {
            // Plays not loaded sound
            reloadForwardSound.Play();
            Debug.Log("Gun is not loaded");
        }
    }


    void Start()
    {
        // Check if bullet is attatched to gun
        if (bullet == null)
        {
            Debug.LogError("Bullet GameObject not attatched to gun");
        }

        // Set bullet rotation to match the gun
        bulletRotation = gameObject.transform.rotation;
        bulletRotation *= Quaternion.Euler(0, 0, 0);

        // Set bullet spawn to location of spawn on gun object
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Set bullet rotation to match the gun
        bulletRotation = gameObject.transform.rotation;

        // Set bullet spawn to location of spawn on gun object
        bulletSpawnPoint = GameObject.Find("BulletSpawnPoint").transform.position;

        // Get potentiometer value
        FromArduino = ArduinoWatcher.GetComponent<ArduinoWatcherScript>().potentiometerValue;

        getAxisInputs();

        // Detect firing input
        if (shootPressed)
        {
            shoot();
        }
        // Detect reload input
        if (FromArduino < 100 && FromArduino > 0 || Input.GetKeyDown("r")) // Clicks into second peg section at around 100;
        {
            reload();
        }

    }
}
