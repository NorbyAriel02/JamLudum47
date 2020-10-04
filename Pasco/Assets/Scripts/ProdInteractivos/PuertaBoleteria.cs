using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaBoleteria : MonoBehaviour
{
    public int numeroPuzzle = 0;
    public PlayerInteraction pi;
    public GameObject puerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PuzzlePuertaBoleteria()
    {
        if(pi.ContainsKey(numeroPuzzle) && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(puerta);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.E))
        {
            PuzzlePuertaBoleteria();
        }
    }
}
