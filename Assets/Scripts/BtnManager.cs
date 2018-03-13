using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour {

    public GameObject[] Btn;

    public void InventoryBtn()
    {
        Btn[0].SetActive(true);
    }

    public void OptionBtn()
    {

    }

    public void ExitBtn()
    {
        Btn[0].SetActive(false);
    }

}
