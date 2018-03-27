using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float StateTime;
    public float AttackTime;

    public PLAYERSTATE playerstate;
    public Transform target;
    public GameObject Hpbar;

    public Dictionary<int, int> Exp;


    float speed = 5;
    public int PlayerAtk;
    public int PlayerDfe;
    public int PlayerHp;

    public enum PLAYERSTATE
    {
        IDLE,
        DAMAGE,
        DEAD,
        ATTACK
    }

    void Awake()
    {
        
    }

	void Start ()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
        Instantiate(Hpbar);
       
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

                if(Input.GetKeyDown(KeyCode.Z))
                {
                    PlayerHp += 5;
                    if(PlayerHp >= 10)
                    {
                        PlayerHp = 10;
                    }
                }

                break;

            case PLAYERSTATE.DAMAGE:

               if(PlayerHp > 0)
                {
                    PlayerHp -= target.GetComponent<unitSTATE>().EnemyAtk - PlayerDfe;
                    //Hpbar.transform.localScale -= new Vector3(0.1f, transform.position.y, transform.position.z);

                    Debug.Log("플레이어의 남은 체력 : " + PlayerHp);
                    playerstate = PLAYERSTATE.IDLE;
                }
               if(PlayerHp == 0)
                {
                    playerstate = PLAYERSTATE.DEAD;
                }

                break;
            case PLAYERSTATE.DEAD:


                Destroy(gameObject);


                break;

            case PLAYERSTATE.ATTACK:

                StateTime += Time.deltaTime;

                if (StateTime >= AttackTime)
                {
                    StateTime = 0f;
                    target.GetComponent<unitSTATE>().unitstate = unitSTATE.UNITSTATE.DAMAGE;
                    playerstate = PLAYERSTATE.IDLE;
                }
                else if(target == null)
                {
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

    //void OnTriggerEnter()
    //{
    //    if(target.gameObject.tag == "Enemy")
    //    {
    //        Debug.Log("적 발견");
    //    }
    //}

}
