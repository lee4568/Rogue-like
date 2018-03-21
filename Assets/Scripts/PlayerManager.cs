using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject PlayerPrefab;
    public GameObject EnemyPrefab;

    void Awake ()
    {

        Vector3 PlayerPos = new Vector3(-7.5f, -2.9f, 0f);
        Instantiate(PlayerPrefab, PlayerPos,Quaternion.Euler(Vector3.zero));

        Vector3 EnemyPos = new Vector3(8f, -2.9f, 0f);
        Instantiate(EnemyPrefab, EnemyPos, Quaternion.Euler(Vector3.zero));

	}
	
	void Update ()
    {
		
	}
}
