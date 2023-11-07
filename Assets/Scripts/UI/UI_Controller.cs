using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    [SerializeField] private GameObject _inventory;
    
    void Start()
    {
        _inventory.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInventory()
    {   
        if(_inventory.activeSelf)
        {
            _inventory.SetActive(false);
        }
        else
        {
            _inventory.SetActive(true);
        }
        
    }
}
