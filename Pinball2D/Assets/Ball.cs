﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook;

    public float releaseTime = .15f;
    public float maxDragDistance = 2f;

    public GameObject nextBall;

    private bool isPressed = false;



    void Update()
    {
        if (isPressed)
        {
            //min40 of vid
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            else
                rb.position = mousePos;
            // rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }
    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {

        yield return new WaitForSeconds(releaseTime);

        //once the ball is fired thats it.
        GetComponent<SpringJoint2D>().enabled = false;
        //cant mess around with ball after its fired.
        this.enabled = false;

        yield return new WaitForSeconds(2f);

        if (nextBall != null)
        {
            nextBall.SetActive(true);
        }
        else
        {
            Pinball.PinballAlive = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
