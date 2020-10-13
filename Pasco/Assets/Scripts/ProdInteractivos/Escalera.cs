using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour
{
    public Vector3 addDeltaZ;    
    bool inPosition = false;    
    private CharacterController cc;
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {        
        if (inPosition)
        {
            if (Input.GetKey(KeyCode.W))
            {
                cc.Move(addDeltaZ * Time.fixedDeltaTime);                
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Si es el personaje el que esta en la escalerilla
        if (other.gameObject.tag.Equals("Player"))
        {
            inPosition = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Si es el personaje el que esta en la escalerilla
        if (other.gameObject.tag.Equals("Player"))
        {            
            inPosition = true;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            inPosition = false;
        }
    }
}
