using UnityEngine;

public class ResetGameObject : MonoBehaviour
{
    public GameObject pointReset;

    public void ResetGame()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.localPosition = pointReset.transform.localPosition;
        transform.localScale = Vector3.one*6;
        GetComponent<Rigidbody>().mass = 1;
        Physics.gravity = ConstantesDeProyecto.gravedad;
    }
}
