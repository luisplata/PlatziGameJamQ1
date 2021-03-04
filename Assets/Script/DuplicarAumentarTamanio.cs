using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicarAumentarTamanio : BasicPlatform
{
    public bool paraHacerGrande;
    protected override void PlayerCollision(Collision collision)
    {
        return;
    }

    protected override void PlayerTrigerEnter(Collider collision)
    {
        if (paraHacerGrande)
        {
            AumentarTamanio(collision.gameObject, 2);
        }
        else
        {
            DisminuirTamanio(collision.gameObject, 2);
        }
    }

    public void ChangeDirection()
    {
        paraHacerGrande = !paraHacerGrande;
    }

    protected override void PlayerCollisionStay(Collision collision)
    {
        return;
    }

    private void AumentarTamanio(GameObject go, int multiplicador)
    {
        go.transform.localScale *= multiplicador;
        go.GetComponent<Rigidbody>().mass *= multiplicador;
    }

    private void DisminuirTamanio(GameObject go, int multiplicador)
    {
        go.transform.localScale /= multiplicador;
        go.GetComponent<Rigidbody>().mass /= multiplicador;
    }

    public override void Accion()
    {
        ChangeDirection();
    }
}
