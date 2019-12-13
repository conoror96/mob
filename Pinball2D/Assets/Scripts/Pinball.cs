using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pinball : MonoBehaviour
{
    public GameObject deathEffect;

    public float health = 4f;

    public static int PinballAlive = 0;

    // Start is called before the first frame update
    void Start()
    {
        PinballAlive++;
    }

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        //relativeVelocity is a 2d vector that compares the velocity of one object to another object in both x & y directions.
        //magnitude converts that into a single number that is the length of the vector or the velocity that they collided at
        //Then check this number is greater than object health. If it is, object gets destroyed

        //Debugging
        Debug.Log(colInfo.relativeVelocity.magnitude);

        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
        else if(colInfo.relativeVelocity.magnitude <= health)
        {

        }

        // what happens when pinball gets destroyed
        void Die()
        {
            // add value to score
            ScoreScript.scorevalue += 10;
            // death effect
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            // one less pinball alive
            PinballAlive--;
            // remove game object
            Destroy(gameObject);

            // I was trying to add in game sounds but ran out of time in the end and couldnt finish
            //SoundManagerScript.PlaySound("pinSound");

            // code had a greater value earlier (used all pins destroyed as a win condition) 
            // now used for debugging
            if (PinballAlive <= 0)
            {
                Debug.Log("all white pins destroyed");
               // Destroy(gameObject);

            }
        }
    }
}
