using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeGrabedad : BasicPlatform
{
    public bool isDown;
    public GameObject row;
    private Vector3 direcction;
    private void Start()
    {
        direcction = Vector3.right;
    }
    public override void Accion()
    {
        isDown = !isDown;
        if (isDown) {
            direcction = Vector3.right;
        }
        else
        {
            direcction = Vector3.right * -1;
        }
    }

    protected override void PlayerCollision(Collision collision)
    {
        if (isDown)
        {   
            Physics.gravity = ConstantesDeProyecto.gravedad;
        }
        else
        {
            Physics.gravity = ConstantesDeProyecto.gravedad * -1;
        }
    }

    protected override void PlayerCollisionStay(Collision collision)
    {
        return;
    }

    private void Update()
    {
        row.transform.LookAt(transform.position + direcction);
    }
}
