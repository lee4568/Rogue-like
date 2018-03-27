using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVdata : MonoBehaviour {

    void Start()
    {

        List<Dictionary<string, object>> data = CSVReader.Read("item");
        Debug.Log(data);
        for (int i = 0; i < data.Count; i++)
        {
            //data[i]["아이템 타입"].ToString();
            //data[i]["아이템 이름"].ToString();
            //int.Parse(data[i]["피해량"].ToString());
            //data[i]["상세"].ToString();
           Debug.Log(data[i]["type"] + "아이템 타입::::" + data[i]["Name"] + "이름 :::" +data[i]["Attack"] + "공격력");

        }

    }

}
