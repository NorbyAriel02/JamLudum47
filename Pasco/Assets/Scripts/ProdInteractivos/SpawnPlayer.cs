using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Transform spawn;
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
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = spawn.position;            
            other.GetComponent<CharacterController>().enabled = true;
            TurnOffTheLight(other);
        }
    }

    void TurnOffTheLight(Collider other)
    {
        other.gameObject.GetComponentInChildren<OpenEyes>().close = true;
        Color off = new Color(0, 0, 0, 1);
        GameObject eyes = GameObject.FindGameObjectWithTag("EYES");
        eyes.GetComponent<Image>().color = off;
    }

}
