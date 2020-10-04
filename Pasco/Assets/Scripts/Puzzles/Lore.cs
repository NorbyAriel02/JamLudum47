using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lore : MonoBehaviour
{
    public int index = 0;
    public string Item = "Generico";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.E))
        {
            PlayerInteraction pi = other.gameObject.GetComponent<PlayerInteraction>();
            pi.AddObjectToListLore(Item, index);
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && Input.GetKey(KeyCode.E))
        {
            PlayerInteraction pi = other.gameObject.GetComponent<PlayerInteraction>();
            pi.AddObjectToListLore(Item, index);
            Destroy(gameObject);
        }
    }
}
