using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Much like the Start() and Update() methods, OnTriggerEnter 2D is a speacial Unity method that is called
    //by unity automatically at a specific point - in this case, when something enters the Trigger attached
    //to this Gameobject
   private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the GameObject that has collided with our trigger is tagged with CleanUp...
        if (collision.gameObject.tag == "CleanUp")
        {
            //Then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
