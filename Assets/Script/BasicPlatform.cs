using System;
using UnityEngine;

public abstract class BasicPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2D"))
        {
            PlayerCollision(collision);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player2D"))
        {
            PlayerCollisionStay(collision);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2D"))
        {
            PlayerTrigerEnter(other);
        }
    }

    public abstract void Accion();

    protected abstract void PlayerCollision(Collision collision);
    protected abstract void PlayerCollisionStay(Collision collision);

    protected virtual void PlayerTrigerEnter(Collider collision){}
}