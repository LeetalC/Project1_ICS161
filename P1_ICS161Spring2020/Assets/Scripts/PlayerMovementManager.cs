using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    private Quaternion currentRotation;

    [SerializeField]
    private float speed;
    public Rigidbody playerRigidBody;

    

    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += transform.forward * Time.deltaTime * speed;
        }

    }

}
