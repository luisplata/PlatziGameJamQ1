using UnityEngine;

public abstract class BasicPlatform : MonoBehaviour
{
    private void OnCollision(Collision collision)
    {
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            PlayerCollision(collision);
        }
    }

    protected abstract void PlayerCollision(Collision collision);
}