using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour {

    public GameObject[] Btn;


    public void PosionBtn()
    {
        GetComponent<Move>().PlayerHp += 1;
    }

    public void InventoryBtn()
    {
        Btn[0].SetActive(true);
        Btn[1].SetActive(true);
    }

    public void ExitBtn()
    {
        Btn[0].SetActive(false);
        Btn[1].SetActive(false);
    }

}
