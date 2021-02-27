using UnityEngine;

public class PlatformJump : BasicPlatform
{
    public float forceInX;
    public Transform angle;
    protected override void PlayerCollision(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(angle.forward * forceInX);
    }
}