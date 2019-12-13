using UnityEngine;
using UnityEngine.SceneManagement;

public class GoldPinball : MonoBehaviour
{

    public GameObject goldDeathEffect;

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
            ScoreScript.scorevalue += 25;
            Instantiate(goldDeathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
