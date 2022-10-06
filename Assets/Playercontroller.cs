using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public GameObject groundchecker;
    public LayerMask whatIsGround;
    public float jumpforce = 150f;

    
    public float maxSpeed = 5.0f;
    bool isOnGround = false;
    bool doubleJump = true;

    // Create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 10.0f;
        } else
        {
            maxSpeed = 5.0f;
        }

        //Create a 'float' that will be equalto the player horizontal input
        float movementValueX = 1.0f;

        //Change the X velocity of the Rigidbody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX * maxSpeed, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundchecker.transform.position, 0.000010f, whatIsGround);
        if (isOnGround == true)
        {
            doubleJump = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
            playerObject.AddForce(new Vector2(0.0f, jumpforce));
            Debug.Log("E");
        }

        else if (Input.GetKeyDown(KeyCode.Space) && doubleJump == true)
        {
            playerObject.velocity = new Vector2(playerObject.velocity.x, 0f);
            playerObject.AddForce(new Vector2(0.0f, jumpforce));
            Debug.Log("E");
            doubleJump = false;
        }

    }
}
