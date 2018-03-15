using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

    public Transform tilePrefab;
    public Vector2 mapSize;

    //public List<string> list;


    //[Range(0,1)]
    //public float Outline;

    //void Start()
    //{
    //    List<string> list = new List<string>();
    //    GenerateMap();
    //}

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
                Vector3 tileposition = new Vector3(-mapSize.x / 5 + 5f + x, -mapSize.y / 5 + 5f + y, 0); //프리팹 사이즈
                Transform newTile = Instantiate(tilePrefab, tileposition, Quaternion.Euler(Vector3.up)) as Transform; // 만들어주는것
                           
                //newTile.localScale = Vector3.one * (0.1f - Outline);

                newTile.parent = mapHolder;
                                
                newTile.name = "Tile" + (x + 1) + "." + (y + 1);


            }
        }
    }

}
