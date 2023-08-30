using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class InventoryWindow : MonoBehaviour
{
    [SerializeField] private RectTransform _itemsPanel;
    readonly List<GameObject> drawIcons = new List<GameObject>();

    void Start()
    {
        InventorySystem.instance.onItemAdded += OnItemAdded;
        Redraw();
    }

    void OnItemAdded(Item obj) => Redraw();

    void Redraw()
    {
        ClearDraws();
        for (var i = 0; i < InventorySystem.instance.inventoryItems.Count; i++)
        {
            var item = InventorySystem.instance.inventoryItems[i];

            var icon = new GameObject("Icon");
            icon.AddComponent<Image>().sprite = item.Icon;
            icon.transform.SetParent(_itemsPanel);

            drawIcons.Add(icon);
        }
    }

    void ClearDraws()
    {
        for (var i = 0; i < drawIcons.Count; i++)
        {
            Destroy(drawIcons[i]);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
