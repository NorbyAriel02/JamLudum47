using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;
public enum CollectableItems
{
    Note,
    Lore,
    Prod
}
public class CollectableItem : MonoBehaviour
{
    public string theTag = "Player";
    public CollectableItems type;
    public string feedback = "You picked up a Note";
    public string descriptio = "none";
    public int numberNote = 0;
    void Start()
    {
        
    }
    public string GetDescription()
    {
        return descriptio;
    }

    public string GetFeedback()
    {
        return feedback;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(theTag) && Input.GetKeyDown(KeyCode.E))
        {
            Interaction pi = other.gameObject.GetComponent<Interaction>();
            pi.player.CanPickUp(gameObject);            
        }
    }
}


