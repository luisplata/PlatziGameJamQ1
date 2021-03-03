using System;
using UnityEngine;

public class AgarradoDePlataformas : MonoBehaviour
{
    [SerializeField]
    public bool PuedeAgarrarPlataforma;
    private GameObject target;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Platforms"))
        {
            PuedeAgarrarPlataforma = true;
            target = other.gameObject;
        }
    }

    public void Agara()
    {
        target.transform.SetParent(transform);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Platforms"))
        {
            PuedeAgarrarPlataforma = false;
            target = null;
        }
    }

    public void Soltar()
    {
        target.transform.SetParent(null);
    }
}