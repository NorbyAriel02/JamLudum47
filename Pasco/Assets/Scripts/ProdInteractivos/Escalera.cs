using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalera : MonoBehaviour
{
    public float velocidadSubida = 5f;
    bool DentroEscalerilla = false;
    public Transform playerPositiom;
    public CharacterController cc;
    public Vector3 addZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = new Vector3(0, velocidadSubida * Time.deltaTime, 0);
        if (DentroEscalerilla == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                cc.Move(addZ * Time.fixedDeltaTime);                
            }
        }
        else
            cc.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        //Si es el personaje el que esta en la escalerilla
        if (other.gameObject.tag.Equals("cuerpo"))
        {
            DentroEscalerilla = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("cuerpo"))
        {
            DentroEscalerilla = false;
        }
    }
}
