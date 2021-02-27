using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitOfMap : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        collision.gameObject.GetComponent<ResetGameObject>().ResetGame();
        if(collision.gameObject.TryGetComponent<PhysicsRender2D>(out var render2d))
        {
            render2d.LetsGoHead = false;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
