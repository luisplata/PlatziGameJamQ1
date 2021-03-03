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

    internal void Accion()
    {
        target.GetComponent<BasicPlatform>().Accion();
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