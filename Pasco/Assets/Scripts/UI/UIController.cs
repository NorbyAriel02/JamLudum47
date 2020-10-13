using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController cc;
    public GameObject panelNotes;
    public List<Button> goListaDeNotas;
    public Text txtNota;
    private bool notesAreOpen = false;    
    private Inventory inventory;
    void Start()
    {
        for (int x = 0; x < 8; x++)
        {
            int index = x;
            goListaDeNotas[x].onClick.AddListener(delegate { GetNote(index); });
        }
        foreach (Button btn in goListaDeNotas)
        {
            btn.gameObject.SetActive(false);
        }
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void GetNote(int index)
    {
        txtNota.text = inventory.GetNote(index);
    }    
    void Update()
    {
        
    }
    void ActiveButton()
    {
        foreach(int index in inventory.GetListNotes().Keys)
        {
            goListaDeNotas[index].gameObject.SetActive(true);
        }        
    }
    public void OpenNotes()
    {
        if (notesAreOpen)
        {
            panelNotes.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            cc.enabled = true;
        }
        else
        {
            panelNotes.SetActive(true);
            ActiveButton();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            cc.enabled = false;
        }

        notesAreOpen = !notesAreOpen;
    }
    public void SetMouseForUIOpen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        cc.enabled = false;
    }
    public void SetMouseForUIClose()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cc.enabled = true;
    }
}
