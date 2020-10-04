using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNotas : MonoBehaviour
{
    public static bool GameIsPause;
    public GameObject goMenuNotas;
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController cc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("el cursor es " + Cursor.visible);
        if(Input.GetKeyDown(KeyCode.I))
        {
            if (GameIsPause)
                Resume();
            else
                Pause();
        }
    }

    void Resume()
    {
        goMenuNotas.SetActive(false);
        //Time.timeScale = 1;
        GameIsPause = false;
        cc.enabled = true;
        Cursor.visible = false;
    }

    private void Pause()
    {
        goMenuNotas.SetActive(true);
        //Time.timeScale = 0;
        GameIsPause = true;
        cc.enabled = false;
        Cursor.visible = true;
    }
}
