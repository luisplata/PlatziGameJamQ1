using UnityEngine;

public class ResetGameObject : MonoBehaviour
{
    public GameObject pointReset;

    public void ResetGame()
    {
        transform.localPosition = pointReset.transform.localPosition;
    }
}
