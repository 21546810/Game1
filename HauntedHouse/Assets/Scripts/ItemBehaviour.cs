using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public string itemName;
    private InventorySystem iSystem;
    
    void Start()
    {
        iSystem = GameObject.Find("Player").GetComponent<InventorySystem>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        iSystem.AddItem(itemName);
        Destroy(gameObject);
    }
}
