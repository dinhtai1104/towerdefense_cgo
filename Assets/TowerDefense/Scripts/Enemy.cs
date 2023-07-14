using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EEnemy
{
    Normal,
    Boss,
}

public class Enemy : MonoBehaviour
{
    public EnemySO enemySO;
    public MoveComponent movement;
    public float Hp;


    private void Start()
    {
        StartMove();
    }

    public void StartMove()
    {
        movement.Set(enemySO.Speed);
    }
}
