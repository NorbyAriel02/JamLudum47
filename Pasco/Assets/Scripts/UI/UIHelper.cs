using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelper : MonoBehaviour
{
    public GameObject timeScale;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UIOpen()
    {
        Cursor.visible = true;
    }

    public static void UIClose(GameObject timeScale)
    {
        Instantiate(timeScale);
    }

    public void SetTextNote(string value)
    {
        GameObject.
            FindGameObjectWithTag("NOTE").
            GetComponent<UINote>().
            txtNote.text = value;
    }
}
