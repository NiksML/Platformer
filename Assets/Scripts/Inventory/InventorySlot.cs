using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public static int selectedSlot;
    public int slot;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SelectSlot);
    }


    private void SelectSlot()
    {
        slot = selectedSlot;
        Debug.Log("selected slot = " + selectedSlot);
    }
}
