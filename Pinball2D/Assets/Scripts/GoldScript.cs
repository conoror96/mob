using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldScript : MonoBehaviour
{

    public GameObject goldDeathEffect; //48.43

    public float health = 4f;

    private void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
        else if (colInfo.relativeVelocity.magnitude <= health)
        {

        }

        void Die()
        {
            ScoreScript.scorevalue += 15;
            Instantiate(goldDeathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
