using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitSTATE : MonoBehaviour {

    public UNITSTATE unitstate;

    public Transform target;

    float STATETIME;
    float ATTACKTIME = 7f;

    public GameObject Door;

    public int hp = 10;

    float speed = 1f;

    public Move playstate;

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
        
    }

	void Start ()
    {
        
    }
	
	void Update ()
    {
        if(hp <= 0)
        {
            unitstate = UNITSTATE.DEAD;
        }

      
        switch (unitstate)
        {
            case UNITSTATE.IDLE:

                
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

                

                break;

            case UNITSTATE.ATTACK:
                STATETIME += Time.deltaTime;
                if(STATETIME == ATTACKTIME)
                {
                    
                }

                float distance1 = (target.position - transform.position).magnitude;
                if (distance1 >= 2f)
                {
                    unitstate = UNITSTATE.WALK;
                }
                
                break;

            case UNITSTATE.DEAD:

                if(hp == 0)
                {
                    Destroy(gameObject);

                    Door.SetActive(true);
                }
                else
                {
                    Door.SetActive(false);
                }
                
                break;
        }
    }

   public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") // 만약 충돌한 오브젝트의 태그가 플레이어라면
        {
            unitstate = UNITSTATE.WALK; // 유닛스테이트를 워크로 변경한다.
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
