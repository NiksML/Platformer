using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject")]
public class Item : ScriptableObject
{
    public static Item instance;
    public string Name = "Item";
    public Sprite Icon;
    public float weight;

    void Start()
    {
        instance = this;
    }

}
