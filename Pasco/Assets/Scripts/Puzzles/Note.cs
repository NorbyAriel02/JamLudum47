using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public string Nota = "esta es la nota 1";
    public int numeroNota = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.E))
        {
            PlayerInteraction pi = other.gameObject.GetComponent<PlayerInteraction>();
            pi.AddNoteToList(Nota, numeroNota);
            Destroy(gameObject);
        }
    }
}
