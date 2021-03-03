using UnityEngine;

public class PlatformLauncher : BasicPlatform
{
    public float forceInX;

    public override void Accion()
    {
        InvertDireccion();
    }

    private void InvertDireccion()
    {
        forceInX *= -1;
    }

    protected override void PlayerCollision(Collision collision)
    {
        return;
    }

    protected override void PlayerCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(forceInX, 0, 0));
    }
}
