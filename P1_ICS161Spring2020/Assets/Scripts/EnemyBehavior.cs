using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float health = 100.0f;
    public float damageRecieved;
    public GameObject Bullet;
    
    // Start is called before the first frame update
    void Start()
    {
       // damageRecieved = GetComponent<BulletBehavior>().GetDamage();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TakeDamage(float damageRecieved)
    {
        health-=damageRecieved;
        if(health <= 0.0f) Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
