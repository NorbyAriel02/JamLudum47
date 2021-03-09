using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUpLadder : MonoBehaviour
{
    public KeyCode keyUp;
    public KeyCode keyDown;
    public float speed = 0.1f;
    private CharacterController cc;
    void Start()
    {
        GetComponent<GoUpLadder>().enabled = false;
    }
    private void OnEnable()
    {
        cc = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (Input.GetKey(keyUp))
        {            
            cc.Move(new Vector3(0, Time.deltaTime * speed, 0));
        }

        if (Input.GetKey(keyDown))
        {            
            cc.Move(new Vector3(0, -Time.deltaTime * speed, 0));
        }
    }
}
