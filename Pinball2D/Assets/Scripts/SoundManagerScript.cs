using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    /* Did not get sound working in the game 
     * in the end  as I ran out of time
     * but this is the code I was working with
     */
    public static AudioClip ballShoot, pinSound, buttonSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        ballShoot = Resources.Load<AudioClip>("ballSound");
        pinSound = Resources.Load<AudioClip>("pinSound");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
            case "ballSound":
                audioSrc.PlayOneShot (ballShoot);
                break;
            case "pinSound":
                audioSrc.PlayOneShot (pinSound);
                break;
        }

    }
}
