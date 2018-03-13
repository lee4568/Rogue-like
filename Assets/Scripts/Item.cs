using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment,
    Consumption,
    Misc
}

[System.Serializable]
public class Item
{
    public string itemName;
    public int itemID;
    public string itemDesc;
    public ItemType itemType;
    public Texture2D itemImage;
    public int itemValue;
    public int itemPrice;

    //public enum ItemType
    //{
    //    Weapon,
    //    Consumable,
    //    Misc
    //}
   
    public Item(string _itemName,int _itemValue,int _itemPrice,string _itemDesc,ItemType _itemType, Texture2D _itemImage)
    {
        itemName = _itemName;
        itemValue = _itemValue;
        itemPrice = _itemPrice;
        itemDesc = _itemDesc;
        itemType = _itemType;
        itemImage = _itemImage;
    }

    //public Item(string name, int id, string desc,int power, int speed,ItemType Type)
    //{
    //    itemName = name;
    //    itemID = id;
    //    itemDesc = desc;
    //    itemType = Type;
    //    itemSpeed = speed;
    //    itemPower = power;
    //    itemIcon = Resources.Load<Texture2D>("Itme Icons/" + name);
    //}

}
