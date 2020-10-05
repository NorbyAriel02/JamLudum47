using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public string nameScene = "Scene2";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {        
        //Si es el personaje el que esta en la escalerilla
        if (other.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
