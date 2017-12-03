using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveBulletHit : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

}
