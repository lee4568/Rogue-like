using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    public GameObject StartBtn;
    public GameObject ExitBtn;

    public void StratButton()
    {
       SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }
}
