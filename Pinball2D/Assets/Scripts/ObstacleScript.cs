using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleScript : MonoBehaviour
{
    public float health = 4f;

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        //Debug.Log(colInfo.relativeVelocity.magnitude);

        if (colInfo.relativeVelocity.magnitude >= health)
        {
            Die();
        }
        else if (colInfo.relativeVelocity.magnitude <= health)
        {

        }

        void Die()
        {
            Destroy(gameObject);
        }
    }
}
