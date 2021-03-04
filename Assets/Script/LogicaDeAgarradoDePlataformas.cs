using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDeAgarradoDePlataformas : MonoBehaviour
{
    public AgarradoDePlataformas agarrado;
    [SerializeField]
    private bool estaAgarrando;

    // Update is called once per frame
    void Update()
    {
        if (estaAgarrando)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                agarrado.Accion();
            }
        }
        if (agarrado.PuedeAgarrarPlataforma)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && !estaAgarrando)
            {
                agarrado.Agara();
                estaAgarrando = true;
            }
            else if (Input.GetKeyDown(KeyCode.LeftShift) && estaAgarrando)
            {
                agarrado.Soltar();
                estaAgarrando = false;
            }
        }
    }
}
