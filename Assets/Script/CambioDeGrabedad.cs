using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeGrabedad : BasicPlatform
{
    public bool isDown;
    public GameObject row;
    private Vector3 direction;


    private void Start()
    {
        direction = Vector3.left;
        
    }
    public override void Accion()
    {
        isDown = !isDown;
        if (isDown) {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.right;
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
        //row.transform.LookAt(new Vector3(0,-90,0), Vector3.left);
        row.transform.LookAt(new Vector3(0, -90, 0), direction);
    }


}