using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitOfMap : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        collision.gameObject.GetComponent<ResetGameObject>().ResetGame();
    }
}
