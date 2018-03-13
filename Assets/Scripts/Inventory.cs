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

    public UITexture InventoryBg;

    void Awake()
    {
        instance = this;
     
    }
    
	void Start ()
    {
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 4; x++)
            {
               Vector3 slotRect = new Vector3((-InventoryBg.transform.position.x / 2f)+ 0.25f * x ,(InventoryBg.transform.position.y * 4.5f) - 0.25f * y, 0);

                //float xmin, ymin, xmax, ymax;

                //slotRect = Rect.MinMaxRect(xmin(0.1f * y + 0.025f),ymin(0.1f * (x + 1.5f) - 0.025f), xmax(0.1f * (y + 1.5f) - 0.025f),ymax(1 - (0.1f * x + 0.025f)));

                //newSlot.GetComponent<RectTransform>();
                //slotRect.anchorMin = new Vector2(0.1f * y + 0.025f, 1 - (0.1f * (x + 1.5f) - 0.025f));
                //slotRect.anchorMax = new Vector2(0.1f * (y +1.5f)- 0.025f, 1 - (0.1f * x + 0.025f));
                //slotRect.offsetMin = Vector2.zero;
                //slotRect.offsetMax = Vector2.zero;

                Transform newSlot = Instantiate(slot, slotRect, Quaternion.Euler(0,0,0))as Transform;
                newSlot.name = "Slot" + (y + 1) + "." + (x + 1);

                newSlot.parent = transform;
                                             
                newSlot.localScale = new Vector3(0.8f,0.8f,0.7f);

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
            _slot.transform.GetChild(0).GetComponent<UITexture>().mainTexture = _slot.item.itemImage;
        }
    }
}
