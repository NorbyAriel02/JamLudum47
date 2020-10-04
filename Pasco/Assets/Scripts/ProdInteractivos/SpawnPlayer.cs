using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Image eyes;
    public GameObject player;
    public GameObject spawn;
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
        //if (other.gameObject.tag.Equals("Player"))
        //{
        //    player.transform.position = spawn.transform.position;
        //}
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = spawn.transform.position;            
            player.GetComponent<CharacterController>().enabled = true;
            OffLigth(other);
        }
    }

    void OffLigth(Collider other)
    {
        other.gameObject.GetComponent<OpenEyes>().close = true;
        Color off = new Color(0, 0, 0, 1);
        eyes.color = off;
    }

}
