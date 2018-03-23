using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ms : MonoBehaviour {

    Ray ray;
    RaycastHit hit;

	// Update is called once per frame
	void Update ()
    {
        OnClick();
	}

    void OnClick()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Physics.Raycast(ray, out hit);
        }

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
