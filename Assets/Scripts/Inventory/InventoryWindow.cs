using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.InputSystem;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] private RectTransform _itemsPanel;
    readonly List<Item> drawIcons = new List<Item>();

    void Start()
    {
        InventorySystem.instance.onItemAdded += OnItemAdded;
        InventorySystem.instance.onItemRemoved += OnItemRemoved;
        Redraw();
    }

    void OnItemAdded(Item obj) => Redraw();
    void OnItemRemoved(Item obj) => Redraw();

    void Redraw()
    {
        drawIcons.Clear();
        for (var i = 0; i < InventorySystem.instance.inventoryItems.Count; i++)
        {
            var slotImage = InventoryGrid.instance.transform.GetChild(i).transform.GetChild(1).gameObject;
            slotImage.SetActive(true);
            var slot = slotImage.GetComponent<Image>();
            var item = InventorySystem.instance.inventoryItems[i];
            var icon = item.Icon;
            slot.sprite = icon;
            drawIcons.Add(item);
        }
    }

}
