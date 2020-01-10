﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;
    private float damage = 95.0f;
    public Rigidbody bulletRB;

    EnemyBehavior Enemy;
    void Start()
    {
        bulletRB.velocity = transform.forward * speed;
    }


    void OnTriggerEnter(Collider collider)
    {
        Enemy = collider.GetComponent<EnemyBehavior>();
        if(Enemy != null) Enemy.TakeDamage(damage);
        Destroy(gameObject);
    }
    public float GetDamage() 
    {
        return damage;
    }



}