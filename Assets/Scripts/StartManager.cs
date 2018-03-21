using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    public GameObject StartBtn;

    public void StratButton()
    {
       SceneManager.LoadScene(1);
    }
}
