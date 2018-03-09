using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    public static Vector2 defaultposition;

    void Start()
    {

    }


    void Update()
    {

    }

    public void OnBeginDrag(PointerEventData eventData) //클릭
    {
        defaultposition = transform.position;
    }

    public void OnDrag(PointerEventData eventData) //드래그
    {
        Vector2 currentPos = Input.mousePosition;
        transform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData) //드롭
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        defaultposition = transform.position;
    }

}
