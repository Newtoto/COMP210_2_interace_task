using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveBulletHit : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision);
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
