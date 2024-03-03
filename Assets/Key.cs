using UnityEngine;
using System.Collections;
public class Key : MonoBehaviour
{
    public bool requireKey;
    void OnTriggerEnter(Collider other)
    {
        if (requireKey && Managers.Inventory.equippedItem != "key")
        {
            return;
        }
    }
}