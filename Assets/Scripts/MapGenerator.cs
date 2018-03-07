using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public Transform tilePrefab;
    public Vector2 mapSize;

    public List<string> list;


    [Range(0,1)]
    public float Outline;

    void Start()
    {
        List<string> list = new List<string>();
        GenerateMap();
    }

    public void GenerateMap()
    {
        string holderName = "Generated Map";
        if(transform.FindChild(holderName))
        {
            DestroyImmediate(transform.FindChild(holderName).gameObject);
        }
        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;
        for(int y = 0; y < mapSize.y; y++)
        {
            for (int x = 0; x < mapSize.x; x++)
            {
                Vector3 tileposition = new Vector3(-mapSize.x / 2 + 0.5f + x, -mapSize.y / 2 + 0.5f + y, 0);
                Transform newTile = Instantiate(tilePrefab, tileposition, Quaternion.Euler(Vector3.up)) as Transform;
                newTile.localScale = Vector3.one * (1 - Outline);
                newTile.parent = mapHolder;
                
                newTile.name = ("Tile"+ 1).ToString();
               

            }
            list.Add("line");

        }
    }

}
