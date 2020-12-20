using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedController : MonoBehaviour
{
    private List<Collision> collisionList = new List<Collision>();
    public bool isGrounded {
        get {return collisionList.Count > 0;}
    } 
    void OnCollisionEnter(Collision collision) {
        collisionList.Add(collision);
    }

    void OnCollisionExit(Collision collision) {
        collisionList.Remove(collision);
    }
}
