using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {

    public static ItemDatabase instance;

    public List<Item> items = new List<Item>();
  

    void Start()
    {
       
    }

    void Awake()
    {
        instance = this;

        Add("axe", 1, 500, "Good Axe", ItemType.Equipment);
        Add("cloaks", 1, 500, "Good cloaks", ItemType.Equipment);
        Add("gloves", 1, 500, "Good gloves", ItemType.Equipment);
        Add("helmets", 1, 500, "Good helmets", ItemType.Equipment);
        Add("sword", 1, 500, "Good sword", ItemType.Equipment);
        Add("apple", 1, 50, "Delicious Apple", ItemType.Equipment);
    }

    void Add(string itemName, int itemValue, int itemPrice, string itemDesc,ItemType itemType)
    {
        items.Add(new Item(itemName, itemValue, itemPrice, itemDesc, itemType, Resources.Load<Texture2D>("ItemImages/" + itemName)));
    }

}
