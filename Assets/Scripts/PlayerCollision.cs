
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // to refer the playermovement script in collision
    public playermovement movement;




    //Inbuilt function in Unity to get info about the collision
    void OnCollisionEnter(Collision collisioninfo)          
    {


        //get collisioninfo using its attributes and tag denotes what group it is tagged under.
        if (collisioninfo.collider.tag == "Obstacle") 
        {
            Debug.Log("we hit an obstacle");

            //On colliding we stop the player from moving
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
