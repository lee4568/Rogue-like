using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    public GameObject StartBtn;

    public void StratButton()
    {
        Application.LoadLevel(1);
    }
}
