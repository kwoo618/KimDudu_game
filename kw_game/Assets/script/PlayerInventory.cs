using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private bool hasKey = false; // 열쇠 소지 여부

    public void PickUpKey()
    {
        hasKey = true;
    }

    public bool HasKey()
    {
        return hasKey;
    }
}
