using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public GameObject ganaste;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<PhysicsRender2D>(out var esEl2D))
        {
            Ganaste();
        }
    }

    private void Ganaste()
    {
        ganaste.SetActive(true);
    }
}
