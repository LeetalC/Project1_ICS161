using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    public float playerMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerMovementSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(playerMovementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f, playerMovementSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
