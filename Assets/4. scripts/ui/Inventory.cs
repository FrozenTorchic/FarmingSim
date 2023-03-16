using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<item> characterItems = new List<item>();
    public ItemDatabase itemDatabase;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RemoveItem(int id)
    {
        item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            Debug.Log("Removed item: " + itemToRemove.title);
        }
    }
    void start()
    {
        GiveItem(1);
        GiveItem(0);
        RemoveItem(1);
    }
    public item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }
    public void GiveItem(int id)
    {
        item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public void GiveItem(string itemName)
    {
        item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
