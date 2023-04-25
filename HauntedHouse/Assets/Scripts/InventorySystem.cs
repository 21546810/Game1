using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // Start is called before the first frame update
    
    //i need to save if the player has the item
    
    //i need to check if the player has an item
    
    //i need to remove an item
    [SerializeField] private List<string> inventoryList = new List<string>();

    public void AddItem(string itemName)
    {
        inventoryList.Add(itemName);
    }

    public bool CheckItem(string itemName)
    {
        if (inventoryList.Contains(itemName))
        {
            return true;
            RemoveItem(itemName);
        }
        else
        {
            return false;
        }
    }

    private void RemoveItem(string itemName)
    {
        inventoryList.Remove(itemName);
    }
}
