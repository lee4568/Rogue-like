using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour {

    public GameObject[] Btn;
    //public GameObject Player;


    //void Start()
    //{
    //    Player.GetComponent<Move>();
    //}

    public void LeftBtn()
    {
       
    }

    public void RightBtn()
    {

    }

    public void Escape()
    {
        Application.Quit();
    }

    public void PosionBtn()
    {
        Debug.Log("체력회복");
    }

    public void InventoryBtn()
    {
        Btn[0].SetActive(true);
        Btn[1].SetActive(true);
        Btn[2].SetActive(false);
        Time.timeScale = 0;
    }

    public void ExitBtn()
    {
        Btn[0].SetActive(false);
        Btn[1].SetActive(false);
        Btn[2].SetActive(true);
        Time.timeScale = 1;
    }

}
