using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour {

    public static Inventory instance;

    public Transform draggingItem;

    public Transform slot;

    public List<Slot> slotScripts = new List<Slot>();

    public Slot enteredSlot;
    
    void Awake()
    {
        instance = this;
    }
    
	void Start ()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Transform newSlot = Instantiate(slot);
                newSlot.name = "Slot" + (x + 1) + "." + (y + 1);
                newSlot.parent = transform;
                RectTransform slotRect = newSlot.GetComponent<RectTransform>();
                slotRect.anchorMin = new Vector2(0.1f * y + 0.025f, 1 - (0.1f * (x + 1.5f) - 0.025f));
                slotRect.anchorMax = new Vector2(0.1f * (y +1.5f)- 0.025f, 1 - (0.1f * x + 0.025f));
                slotRect.offsetMin = Vector2.zero;
                slotRect.offsetMax = Vector2.zero;

                slotScripts.Add(newSlot.GetComponent<Slot>());
                newSlot.GetComponent<Slot>().number = x * 5 + y;
            }
        }
        AddItem(0);
        AddItem(1);
        AddItem(2);
        AddItem(3);
        AddItem(4);
        AddItem(5);
        


    }
	

	void AddItem(int number)
    {
        for (int i = 0; i < slotScripts.Count; i++)
        {
            if(slotScripts[i].item.itemValue == 0)
            {
                slotScripts[i].item = ItemDatabase.instance.items[number];
                ItemImageChange(slotScripts[i]);
                break;
            }
        }
    }


    public void ItemImageChange(Slot _slot)
    {
        if(_slot.item.itemValue == 0)
        {
            _slot.transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            _slot.transform.GetChild(0).gameObject.SetActive(true);
            _slot.transform.GetChild(0).GetComponent<Image>().sprite = _slot.item.itemImage;
        }
    }
}
