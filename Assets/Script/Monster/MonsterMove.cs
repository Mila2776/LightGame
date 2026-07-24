using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MonsterMove : MonoBehaviour
{

    //public Transform pointA;
    //public Transform pointB;

    public Transform[] PatrolPoints;
    public Transform Player;
    private Transform Target;

    private int CurrentPoint = 0;

    //玩家是否在範圍裡
    public bool IsPlayerInRange = false;
    //怪物速度
    public float speed = 2f;

    public Candle CandleSystem;

    void Start()
    {
        //target = pointB;
        //transform.position = PatrolPoints[0].position;
        Target = PatrolPoints[CurrentPoint];

    }

    void Update()
    {
        if (IsPlayerInRange && CandleSystem.IsLightOn)
        {
            Debug.Log("玩家進入警戒範圍");
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
        
    }

    void Patrol()
    {
        Transform target = PatrolPoints[CurrentPoint];

        transform.position = Vector2.MoveTowards(transform.position,target.position,speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            CurrentPoint++;

            if (CurrentPoint >= PatrolPoints.Length)
            {
                CurrentPoint = 0;
            }
        }
    }

    void ChasePlayer()
    {
       transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
    }
}
