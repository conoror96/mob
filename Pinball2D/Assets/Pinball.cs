using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    public GameObject deathEffect; //48.43

    public float health = 4f;

    public static int PinballAlive = 0;

    private void Start()
    {
        PinballAlive++;
    }

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        //relativeVelocity is a 2d vector that compares the velocity of one object to another object in both x & y directions.
        //magnitude converts that into a single number that is the length of the vector or the velocity that they collided at.
        // Debug.Log(colInfo.relativeVelocity.magnitude);

        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }

        void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);

            PinballAlive--;
            if (PinballAlive <= 0)
                Debug.Log("LEVEL WON!");

            Destroy(gameObject);
        }
    }
}
