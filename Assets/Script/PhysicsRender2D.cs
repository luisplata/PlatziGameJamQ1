using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysicsRender2D : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Button buttonStartSimulation;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        buttonStartSimulation.onClick.AddListener(() =>
        {
            rigidbody.useGravity = true;
        });
    }
}
