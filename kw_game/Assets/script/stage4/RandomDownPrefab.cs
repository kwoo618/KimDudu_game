using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDownPrefab : MonoBehaviour
{
    public GameObject newPrefab;
    public float intervalSec = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatePrefab", intervalSec, intervalSec);
    }

    // Update is called once per frame
    void CreatePrefab()
    {
        Vector3 area = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 newPos = this.transform.position;
        newPos.x += Random.Range(-area.x / 2, area.x / 2);
        newPos.y += Random.Range(-area.y / 2, area.y / 2);
        newPos.z = -5;

        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;

        // Set the rotation to face downward (assuming downward is Vector3.down)
        newGameObject.transform.rotation = Quaternion.Euler(0, 0, -90); // Adjust the rotation as needed
    }
}
