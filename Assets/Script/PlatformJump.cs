using UnityEngine;

public class PlatformJump : BasicPlatform
{
    public float forceInX;
    public Transform angle;

    public override void Accion()
    {
        throw new System.NotImplementedException();
    }

    protected override void PlayerCollision(Collision collision)
    {
        return;
    }

    protected override void PlayerCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(angle.forward * forceInX);
    }
}