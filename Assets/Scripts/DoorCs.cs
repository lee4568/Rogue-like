using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCs : MonoBehaviour
{

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("이동하시겠습니까?");
        }
    }

}
