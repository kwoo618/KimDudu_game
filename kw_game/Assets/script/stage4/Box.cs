using UnityEngine;

public class Box : MonoBehaviour
{
    public Vector3 targetPosition; // ?? ??
    public GameObject wall; // ??? ?
    public float tolerance = 0.1f; // ?? ?? ??

    private void Update()
    {
        // ??? ?? ??? ????? ??
        if (Vector3.Distance(transform.position, targetPosition) < tolerance)
        {
            // ?? ????
            wall.SetActive(false);
        }
    }
}
