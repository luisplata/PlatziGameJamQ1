using UnityEngine;

public class ResetGameObject : MonoBehaviour
{
    public GameObject pointReset;

    public void ResetGame()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.localPosition = pointReset.transform.localPosition;
    }
}
