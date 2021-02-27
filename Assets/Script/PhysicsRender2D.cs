using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRender2D : MonoBehaviour
{
    private Vector3 forceGravity;
    private Rigidbody rigidbody;
    public float gravitationalAcceleration;
    public bool LetsGoHead;
    // Start is called before the first frame update
    void Start()
    {
        forceGravity = new Vector3(0,0,-1);
        rigidbody = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        if (LetsGoHead)
        {
            rigidbody.velocity += gravitationalAcceleration * Time.fixedTime * forceGravity;
        }
    }
}
