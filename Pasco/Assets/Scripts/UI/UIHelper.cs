using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelper : MonoBehaviour
{
    // Start is called before the first frame update
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
        //GameObject.
        //        FindGameObjectWithTag("Player").
        //        GetComponent<GameCreator.Characters.PlayerCharacter>()
        //        .enabled = false;
        //GameObject.
        //    FindGameObjectWithTag("MainCamera").
        //    GetComponent<GameCreator.Camera.CameraController>()
        //    .enabled = false;
        Time.timeScale = 0;
        Cursor.visible = true;
    }

    public static void UIClose()
    {
        //GameObject.
        //        FindGameObjectWithTag("Player").
        //        GetComponent<GameCreator.Characters.PlayerCharacter>()
        //        .enabled = true;
        //GameObject.
        //    FindGameObjectWithTag("MainCamera").
        //    GetComponent<GameCreator.Camera.CameraController>()
        //    .enabled = true;
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    public void SetTextNote(string value)
    {
        GameObject.
            FindGameObjectWithTag("NOTE").
            GetComponent<UINote>().
            txtNote.text = value;
    }
}
