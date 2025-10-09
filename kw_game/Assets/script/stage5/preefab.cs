using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preefab : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;

    private Collider2D areaCollider;

    // Start is called before the first frame update
    void Start()
    {
        areaCollider = GetComponent<Collider2D>();
        if (areaCollider == null)
        {
            Debug.LogError("Collider2D component is missing.");
            return;
        }

        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    // Update is called once per frame
    void CreatePrefab()
    {
        if (areaCollider == null) return;

        Bounds bounds = areaCollider.bounds;

        Vector3 newPos = new Vector3(
            Random.Range(bounds.min.x, bounds.max.x),
            Random.Range(bounds.min.y, bounds.max.y),
            -5f // You can adjust the z-position as needed
        );

        GameObject newGameObject = Instantiate(newPrefab, newPos, Quaternion.identity);
    }
}
