using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreScript : MonoBehaviour
{
    public static int scorevalue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scorevalue;
       
        // These nested if statements set different difficulty for each level
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (scorevalue >= 30)
            {
                Debug.Log("LEVEL 1 WON!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                scorevalue = 0;
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (scorevalue >= 50)
            {
                Debug.Log("LEVEL 2 WON!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                scorevalue = 0;
            }
        }
        else
        {
            if (scorevalue >= 70)
            {
                Debug.Log("LEVEL 3 WON!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                scorevalue = 0;
            }
        }
    }
}
