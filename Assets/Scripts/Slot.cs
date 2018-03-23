using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour/*IDragHandler, IPointerEnterHandler, IPointerExitHandler, IEndDragHandler*/
{
    public int number;
    public Item item;

    public enum SLOTSTATE
    {
        NONE,
        OnDrag,
        OnPointerEnter,
        OnPointerExit,
        OnEndDrag
    }

    void Awake()
    {
       
    }

    void Start()
    {
        
    }
        
    void OnDrag()
    {
        if (transform.childCount > 0) // 만약 Slot의 게임 오브젝트의 자식의 수가 0보다 클 경우..
        {
            transform.GetChild(0).parent = Inventory.instance.draggingItem; //Slot의 0번 째 자식 계체를 인스턴스화 한 인벤토리의 드레깅아이템으로 집어넣는다.
        }
        //Inventory.instance.draggingItem.GetChild(0).position = 
    }

    void OnPointerEnter()
    {
        Inventory.instance.enteredSlot = this;
    }

    void OnPointerExit()
    {
        Inventory.instance.enteredSlot = this;
    }

    void OnEndDrag()
    {
        Inventory.instance.draggingItem.GetChild(0).parent = transform;
        gameObject.transform.GetChild(0).localPosition = Vector3.zero;

        if (Inventory.instance.enteredSlot != null)
        {
            Item tempItem = item;
            item = Inventory.instance.enteredSlot.item;

            Inventory.instance.enteredSlot.item = tempItem;
            Inventory.instance.ItemImageChange(this);
            Inventory.instance.ItemImageChange(Inventory.instance.enteredSlot);
        }
    }
}
