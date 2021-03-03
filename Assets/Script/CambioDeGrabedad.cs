using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeGrabedad : BasicPlatform
{
    public bool isDown;
    public override void Accion()
    {
        isDown = !isDown;
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
}
