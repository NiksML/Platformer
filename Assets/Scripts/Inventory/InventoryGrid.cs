using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGrid : MonoBehaviour
{
    public int maxSlots;
    public static InventoryGrid instance;

    void Start()
    {
        instance = this;

        for(int i = 0; i < maxSlots; i++)
        {
            transform.GetChild(i).GetComponent<InventorySlot>().slot = i;
        }
    }
}
