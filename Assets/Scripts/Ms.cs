using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ms : MonoBehaviour {

    Ray ray;
    Ray uiray;
    RaycastHit hit;
    RaycastHit uihit;

    // Update is called once per frame
    

    void Update ()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        uiray = UICamera.mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Physics.Raycast(ray, out hit);
            Physics.Raycast(uiray, out uihit);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.name);
            }
            if (uihit.collider != null)
            {
                Debug.Log(uihit.collider.name);
            }
        }

      
    }
}

//    void OnClick()
//    {
//        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        uiray = UICamera.mainCamera.ScreenPointToRay(Input.mousePosition);

//        if (Input.GetKeyDown(KeyCode.Mouse0))
//        {
//            Physics.Raycast(ray, out hit);
//            Physics.Raycast(uiray, out uihit);
//        }

//        if (hit.collider != null)
//        {
//            Debug.Log(hit.collider.name);
//        }
//        if (uihit.collider != null)
//        {
//            Debug.Log(uihit.collider.name);
//        }
//    }
//}
