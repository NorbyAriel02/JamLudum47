using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public List<GameObject> recolectables;
    List<string> list = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddObjectToList(string value)
    {
        list.Add((string)value);
        foreach(GameObject go in recolectables)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                break;
            }                
        }
        foreach(string item in list)
        {
            Debug.Log(item);
        }

    }

}
