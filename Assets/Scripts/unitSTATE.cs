using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitSTATE : MonoBehaviour {

    public UNITSTATE unitstate;

    public Transform target;

    public Transform door;


    public float STATETIME;
    public float ATTACKTIME;

    public int hp = 10;
    public int EnemyAtk;

    float speed = 1f;
        
    public Vector3 direction;

    RaycastHit hit;

    public enum UNITSTATE
    {
        IDLE,
        WALK,
        DAMAGE,
        ATTACK,
        DEAD
    }

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        door = GameObject.FindGameObjectWithTag("Object").transform;
    }

	void Start ()
    {
      if(door.gameObject.activeSelf == true)
        {
            door.gameObject.SetActive(false);
        }
    }

    void Update ()
    {
        Debug.DrawRay(gameObject.transform.position, Vector3.left * 6f, Color.red);



        //if (Physics.Raycast(gameObject.transform.position, Vector3.left, out hit, 6f))
        //{
        //    if (hit.collider.tag == "Player")
        //    {
        //        unitstate = UNITSTATE.WALK;

        //        if (playerstate == Move.PLAYERSTATE.ATTACK)
        //        {
        //            unitstate = UNITSTATE.DAMAGE;
        //        }

        //    }   
        //}
        

        switch (unitstate)
        {
            case UNITSTATE.IDLE:

                //if (target.GetComponent<Move>().playerstate == null)
                //{

                //}

                break;

            case UNITSTATE.WALK:

                float distance = (target.position - transform.position).magnitude;
                if (distance <= 2f) // 만약 타겟과의 거리가 2보다 작을 경우 어택상태로 변경한다.
                {
                    unitstate = UNITSTATE.ATTACK;
                }

                Vector3 dir = target.position - transform.position;
                dir.Normalize();
                gameObject.transform.Translate(dir * speed * Time.deltaTime);

                break;

            case UNITSTATE.DAMAGE:
                if (hp > 0)
                {

                    hp -= target.GetComponent<Move>().PlayerAtk;
                    Debug.Log("적의 남은 체력 : " + hp);
                    unitstate = UNITSTATE.ATTACK;

                }

                //if (hp <= 0)
                //{
                //    //unitstate = UNITSTATE.DEAD;
                //}
                break;

            case UNITSTATE.ATTACK:

                STATETIME += Time.deltaTime;
                if (STATETIME >= ATTACKTIME)
                {
                    STATETIME = 0f;
                    target.GetComponent<Move>().playerstate = Move.PLAYERSTATE.DAMAGE;
                    unitstate = UNITSTATE.ATTACK;
                }

                //else if (target.GetComponent<Move>().playerstate == Move.PLAYERSTATE.ATTACK)
                //{
                //    unitstate = UNITSTATE.DAMAGE;
                //}


                float distance3 = (target.position - transform.position).magnitude;
                if (distance3 >= 2f)
                {
                    unitstate = UNITSTATE.WALK;
                }

                //if (hit.distance <= 2f)
                //{
                //    unitstate = UNITSTATE.WALK;
                //}

                break;

            case UNITSTATE.DEAD:

                if (hp <= 0)
                {
                    Destroy(gameObject);
                    door.gameObject.SetActive(true);
                }
                
                break;
        }
    }

   public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") // 만약 충돌한 오브젝트의 태그가 플레이어라면
        {
            unitstate = UNITSTATE.WALK;           
        }
                      
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            unitstate = UNITSTATE.IDLE;
        }
    }
}
