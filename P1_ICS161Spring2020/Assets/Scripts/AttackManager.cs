using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public Transform firingPoint;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) Shoot();
    }
    
    void Shoot() 
    {
        Instantiate(Bullet, firingPoint.position, firingPoint.transform.rotation);
    }
}
