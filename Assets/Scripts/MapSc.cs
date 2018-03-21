using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSc : MonoBehaviour
{
    public GameObject[] Stage;

    void Start()
    {
        int map = Random.Range(0, 6);
        Debug.Log(map);
        switch (map)
        {
            case 0:
                Instantiate(Stage[0]);
                break;
            case 1:
                Instantiate(Stage[1]);
                break;
            case 2:
                Instantiate(Stage[2]);
                break;
            case 3:
                Instantiate(Stage[3]);
                break;
            case 4:
                Instantiate(Stage[4]);
                break;
            case 5:
                Instantiate(Stage[5]);
                break;
        }
    }
}
