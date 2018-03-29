using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Selectbutton : MonoBehaviour {

    public GameObject btn;

	public void SelectBtn()
    {
        Debug.Log(btn.gameObject.name);
        SceneManager.LoadScene(2);
    }
}
