using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<item> items = new List<item>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void BuildDatabase()
    {
        items = new List<item>()
        {
            new item(0, "Dimand Sword", "A sword made of diamond.",
            new Dictionary<string, int>
            {
                {"Power", 15 },
                {"Defence", 10 }
            }),
            new item(1, "Diamond Ore", "A pretty diamond.",
            new Dictionary<string, int>
            {
                {"Value", 300 }
            }),
            new item(2, "Silver Pick", "A pick that could kill a vapire.",
            new Dictionary<string, int>
            {
                {"Power", 5 },
                {"Mining", 20 }
            })
        };
    }

    public item GetItem(int id)
    {
        return items.Find(item=> item.id == id);
    }

    public item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }
    void Awake()
    {
        BuildDatabase();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
