using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInventory : MonoBehaviour {

    public static NewInventory instance;

    public Transform slot;
	
	void Start ()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                Transform newSlot = Instantiate(slot);
            }
        }
    }
	
}
