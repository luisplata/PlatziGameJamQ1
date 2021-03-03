using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller3DPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceExternal;
    public float forceRotation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        MovePlayer(vertical, horizontal);
    }

    private void MovePlayer(float X, float Y)
    {

        Vector3 force = transform.forward * X * forceExternal;
        GetComponent<Rigidbody>().velocity =force;
        //agregamos rotacion
        if(Y != 0)
        {
            transform.Rotate(0, Y * forceRotation, 0);
        }
    }
}
