using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SiguiendoObjeto : MonoBehaviour
{
    public GameObject target;
    private Rigidbody rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        var diff = target.transform.position - transform.position;
        rb.velocity = diff.normalized * speed;
    }
}
