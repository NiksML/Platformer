using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


public class InventorySystem : MonoBehaviour
{
    public Action<Item> onItemAdded;
    public Action<Item> onItemRemoved;
    public static InventorySystem instance;

    [SerializeField] public List<Item> StartItems = new List<Item>();
    [SerializeField] public List<Item> inventoryItems = new List<Item>();

    //[SerializeField] private Transform _InventoryList;

    void Awake()
    {
        instance = this;
        for (var i = 0; i < StartItems.Count; i++)
        {
            AddItem(StartItems[i]);
            Debug.Log(StartItems[i]);
        }
    }

    public void AddItem(Item item)
    {
        inventoryItems.Add(item);
        Debug.Log("added " +  item);
        onItemAdded?.Invoke(item);
    }

    public void DropItem(Item item)
    {
        inventoryItems.Remove(item);
        Debug.Log("removed " + item);
        onItemRemoved?.Invoke(item);
    }
}
