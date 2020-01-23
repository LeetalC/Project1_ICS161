using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    private Quaternion currentRotation;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Rigidbody playerRigidBody;


    void Start()
    {
        speed = 5.0f;
    }

    // Player can only move in the four cardinal directions. 
    void Update()
    {
 
        if (Input.GetKey(KeyCode.W)) {
            MoveCharacter(new Vector3(0, 0, 0));
        }
        else if(Input.GetKey(KeyCode.S)) {
            MoveCharacter(new Vector3(0, -180, 0));
        }
        else if (Input.GetKey(KeyCode.A)){
            MoveCharacter(new Vector3(0, -90, 0));
        }
        else if(Input.GetKey(KeyCode.D)) {
            MoveCharacter(new Vector3(0, 90, 0));

        }

    }

    private void MoveCharacter(Vector3 eulerVec) {
        transform.rotation = Quaternion.Euler(eulerVec);
        transform.position += transform.forward * Time.deltaTime * speed;
    }

}
