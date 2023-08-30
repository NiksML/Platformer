using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTaker : MonoBehaviour
{
    private Item _itemToAdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _itemToAdd = col.GetComponent<TakebleItem>()._visibleItemInInventory;
        InventorySystem.instance.AddItem(_itemToAdd);
        Destroy(col.gameObject);
    }
}
