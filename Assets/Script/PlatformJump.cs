using UnityEngine;

public class PlatformJump : BasicPlatform
{
    public float forceInX;
    public float forceRotation;
    public Transform angle;
    private bool moveAngle;

    public override void Accion()
    {
        moveAngle = !moveAngle;
    }

    protected override void PlayerCollision(Collision collision)
    {
        return;
    }

    protected override void PlayerCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(angle.up * forceInX);
    }

    private void Update()
    {
        if (!moveAngle)
        {
            return;
        }
        var horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            MovePlatform(horizontal);
        }
    }

    private void MovePlatform(float Y)
    {
        //agregamos rotacion
        if (Y != 0)
        {
            angle.Rotate(0, 0, Y * forceRotation);
        }
    }
}