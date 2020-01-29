using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    

    public float Forwardforce = 2000f;

    public float Sidewayforce = 600f;



    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, Forwardforce * Time.deltaTime);  

        if(Input.GetKey("d"))
        {
            rb.AddForce(Sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // fourth parameter is to change the direction quickly while moving
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-Sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        /*if(Input.GetKey("w"))
        {
            rb.AddForce(0, Sidewayforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -Sidewayforce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }*/

        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
