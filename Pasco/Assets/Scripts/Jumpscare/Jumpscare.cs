using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public float delay = 2f;
    public AudioSource sound;
    //public GameObject player;
    public GameObject JumpCam;
    private bool once = false;
    
    void Trigger()
    {
        sound.Play();
        JumpCam.SetActive(true);
        //player.SetActive(false);
        StartCoroutine(EndJump());
    }

    IEnumerator EndJump()
    {        
        yield return new WaitForSeconds(delay);
        //player.SetActive(true);
        JumpCam.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !once)
        {
            once = true;
            Trigger(); 
        }
    }
}
