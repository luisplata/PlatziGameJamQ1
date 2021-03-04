using UnityEngine;

public class PlatformLauncher : BasicPlatform
{
    public float forceInX;
    public GameObject seniales;
    public bool estaAcionado;

    public override void Accion()
    {
        InvertDireccion();
    }

    private void InvertDireccion()
    {
        forceInX *= -1;
        var scale = seniales.transform.localScale;
        scale.x *= -1;
        seniales.transform.localScale = scale;
        estaAcionado = !estaAcionado;
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
