﻿using UnityEngine;

public class ResetGameObject : MonoBehaviour
{
    public GameObject pointReset;

    public void ResetGame()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.localPosition = Vector3.zero; //pointReset.transform.localPosition;
        var escalar = 1;
        if(TryGetComponent<PhysicsRender2D>(out var d2d))
        {
            escalar = 6;
        }
        transform.localScale = Vector3.one * escalar;
        GetComponent<Rigidbody>().mass = 1;
        Physics.gravity = ConstantesDeProyecto.gravedad;
    }
}
