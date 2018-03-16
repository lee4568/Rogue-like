using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float StateTime;
    public float AttackTime;

    public PLAYERSTATE playerstate;

    Transform target;

    public int hp = 10;

    float speed = 5;

    public unitSTATE unitstate;

    public enum PLAYERSTATE
    {
        IDLE,
        DAMAGE,
        ATTACK
    }

	void Start ()
    {
        unitSTATE unitstate = GetComponent<unitSTATE>();
	}
	
	
	void Update ()
    {
              
        float x = Input.GetAxisRaw("Horizontal");

        transform.Translate(x * speed * Time.deltaTime, 0, 0);

      
        switch (playerstate)
        {
            case PLAYERSTATE.IDLE:

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    playerstate = PLAYERSTATE.ATTACK;
                }

                break;

            case PLAYERSTATE.DAMAGE:

                

                break;
          
            case PLAYERSTATE.ATTACK:

                StateTime += Time.deltaTime;

                if (StateTime >= AttackTime)
                    {
                      StateTime = 0f;
                      playerstate = PLAYERSTATE.IDLE;
                    }

                break;

            default:

                break;
        }

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

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            target = GameObject.FindGameObjectWithTag("Enemy").transform;
        }
    }
    
}
