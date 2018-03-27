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

    public Transform InventoryBg;

    void Awake()
    {
        instance = this;
    }
    
	void Start ()
    {
        float magin;
        int m;
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (x > 0)
                {
                    magin = 1.25f;
                }
                else
                {
                    magin = 0f;
                }
                //if (x > 1) m = -1;
                //else
                m = 1;

                Vector3 slotRect = new Vector3((x+0.75f)* m * 100 * m, (y+0.65f) * m * -100 *m, 0);
                /*new Vector3((-InventoryBg.transform.position.x / 2f)+ 0.25f * x ,(InventoryBg.transform.position.y * 4.5f) - 0.25f * y, 0);*/
                
                //Transform newSlot = Instantiate(slot);

                //RectTransform slotRect = newSlot.GetComponent<RectTransform>();

                //slotRect.anchorMin = new Vector2(0.1f * y + 0.025f, 1 - (0.1f * (x + 1.5f) - 0.025f));
                //slotRect.anchorMax = new Vector2(0.1f * (y +1.5f)- 0.025f, 1 - (0.1f * x + 0.025f));
                //slotRect.offsetMin = Vector2.zero;
                //slotRect.offsetMax = Vector2.zero;

                Transform newSlot = Instantiate(slot)as Transform;
                newSlot.name = "Slot" + (y + 1) + "." + (x + 1);

                newSlot.parent = transform;

                newSlot.transform.localPosition = slotRect;
                newSlot.transform.rotation = Quaternion.Euler(0, 0, 0);
             
                

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
            if (slotScripts[i].item.itemValue == 0)
            {
                slotScripts[i].item = ItemDatabase.instance.items[number];
                ItemImageChange(slotScripts[i]);
                break;
            }
        }
    }


    public void ItemImageChange(Slot _slot)
    {

        if (_slot.item.itemValue <= 0)
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
