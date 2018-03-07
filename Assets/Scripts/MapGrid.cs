using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGrid : MonoBehaviour {

    public float width = 32f;
    public float height = 32f;

    public Color color = Color.white;
	
    void Update()
    {

    }



    void OnDrawGizmos()
    {
        Vector3 pos = Camera.current.transform.position;
        Gizmos.color = color;

        for (float y = pos.y - 800f; y < pos.y + 800f; y += height)
        {
            Gizmos.DrawLine(new Vector3(-1000f, Mathf.Floor(y / height) * height, 0f), new Vector3(1000f, Mathf.Floor(y / height) * height, 0f));
        }
        for (float x = pos.x - 1200f; x < pos.x + 1200f; x += width)
        {
            Gizmos.DrawLine(new Vector3(Mathf.Floor(x / width) * width, -1000f, 0f), new Vector3(Mathf.Floor(x / width) * width, 1000f, 0f));
        }
    }
}
