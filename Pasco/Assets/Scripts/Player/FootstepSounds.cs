using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioClip[] footStepSounds;
    private CharacterController cc;
    private AudioSource audioSource;
    private int step = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (step > (footStepSounds.Length - 1))
                step = 0;

            if(!audioSource.isPlaying)
            {
                audioSource.clip = footStepSounds[step];
                audioSource.Play();
                step++;
            }
        }
    }
}
