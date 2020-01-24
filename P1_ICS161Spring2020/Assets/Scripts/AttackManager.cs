using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [SerializeField]
    private Transform firingPoint;
    
    [SerializeField]
    private GameObject Bullet;

    void Update()
    {
        if(Input.GetKeyDown("space")) Shoot();
    }
    
    void Shoot() 
    {
        Instantiate(Bullet, firingPoint.position, firingPoint.transform.rotation);
    }
}
