using UnityEngine;

public class PlatformLauncher : BasicPlatform
{
    public float forceInX;
    protected override void PlayerCollision(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(forceInX, 0, 0));
    }
}
