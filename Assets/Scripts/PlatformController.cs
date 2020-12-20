using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private Rigidbody rb;
    void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Player") {
            Invoke("dropPlatform", 0.5f);
            Destroy(gameObject, 10f);
        }
    }

    void dropPlatform() {
        transform.SetParent(null);
        rb.isKinematic = false;
    }
}
