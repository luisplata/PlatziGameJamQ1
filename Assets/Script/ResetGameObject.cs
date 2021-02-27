using UnityEngine;

public class ResetGameObject : MonoBehaviour
{
    public float X, Y, Z;

    public void ResetGame()
    {
        transform.localPosition = new Vector3(X, Y, Z);
    }
}
