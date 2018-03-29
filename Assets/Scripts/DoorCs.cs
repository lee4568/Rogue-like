using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCs : MonoBehaviour
{

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log("이동하시겠습니까?");
            
            SceneManager.LoadScene(2);
        }
        
    }

}
