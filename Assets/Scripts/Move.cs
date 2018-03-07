using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public int hp = 10;

    float speed = 10;

	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        float x = Input.GetAxisRaw("Horizontal");

        transform.Translate(x * speed * Time.deltaTime, 0, 0);


        //if(Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //   transform.Translate(0.5f, 0, 0);
        //}
        //else if(Input.GetKeyDown(KeyCode.LeftArrow))
        //{ 
        //   transform.Translate(-0.5f, 0, 0);
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GetComponent<Animator>().Play("Cleric Attack");
        //}
        //else
        //{
        //    GetComponent<Animator>().Play("Cleric Idle");
        //}



    }
}
