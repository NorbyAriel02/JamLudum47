using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
{
    public int NumberKey = 0;
    public GameObject Close;
    public GameObject open;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Open()
    {
        Destroy(Close);
        open.SetActive(true);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Hand") && Input.GetKey(KeyCode.E))
        {
            Interaction script = other.GetComponent<Interaction>();
            if (script.inventory.ContainsKey(NumberKey))
                Open();
        }
    }
}
