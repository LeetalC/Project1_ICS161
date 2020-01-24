using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 25.0f;
    
    [SerializeField]
    private float damage = 100.0f;

    [SerializeField]
    private Rigidbody bulletRB;

    EnemyBehavior Enemy;

    void Start()
    {

        bulletRB.velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider collider)
    {
       Debug.Log(collider.gameObject.name);
        Enemy = collider.GetComponent<EnemyBehavior>();
        if (Enemy != null)
        {
            Enemy.TakeDamage(GetDamage());

        }
        if(collider.gameObject.name != "Player")
        Destroy(gameObject);


    }

    public float GetDamage() 
    {
        return damage;
    }
    public float GetSpeed()
    {
        return speed;
    }



}
