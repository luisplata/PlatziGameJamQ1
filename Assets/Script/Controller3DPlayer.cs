using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller3DPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceExternal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        MovePlayer(horizontal, vertical);
    }

    private void MovePlayer(float X, float Y)
    {
        
        Vector3 force = new Vector3(X, 0, Y) * forceExternal;
        Debug.Log($"velocity {force}");
        GetComponent<Rigidbody>().velocity =force;
    }
}
