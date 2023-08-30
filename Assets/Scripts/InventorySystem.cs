using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class InventorySystem : MonoBehaviour
{
    public Action<Item> onItemAdded;
    public static InventorySystem instance;

    [SerializeField] public List<Item> _StartItems = new List<Item>();
    [SerializeField] public List<Item> inventoryItems = new List<Item>();

    //[SerializeField] private Transform _InventoryList;

    void Awake()
    {
        instance = this;
        for (var i = 0; i < _StartItems.Count; i++)
        {
            AddItem(_StartItems[i]);
            Debug.Log(_StartItems[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        Debug.Log("added " +  item);
        onItemAdded?.Invoke(item);
    }
}
