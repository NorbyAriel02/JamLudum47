using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public Transform cursorCustom;
    public UIController uic;
    public List<GameObject> recolectables;
    public List<Button> goListaDeNotas;
    public Dictionary<int, string> ListaDeNotas = new Dictionary<int, string>();
    public Text txtNota;
    public GameObject BgNotas;
    bool menuNoteActive = false;
    Dictionary<int, string> ListaDeProd = new Dictionary<int, string>();
    Dictionary<int, string> ListaDeProdLore = new Dictionary<int, string>();
    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController cc;
    // Start is called before the first frame update
    void Start()
    {        
        goListaDeNotas[0].onClick.AddListener(ShowTextNota);
        goListaDeNotas[1].onClick.AddListener(ShowTextNota2);
        goListaDeNotas[2].onClick.AddListener(ShowTextNota3);
        goListaDeNotas[3].onClick.AddListener(ShowTextNota4);
        goListaDeNotas[4].onClick.AddListener(ShowTextNota5);
        goListaDeNotas[5].onClick.AddListener(ShowTextNota6);
        goListaDeNotas[6].onClick.AddListener(ShowTextNota7);
        goListaDeNotas[7].onClick.AddListener(ShowTextNota8);
        foreach (Button btn in goListaDeNotas)
        {                        
            btn.gameObject.SetActive(false);
        }
    }
    public void ActiveBGNote()
    {
        BgNotas.SetActive(!BgNotas.activeSelf);        
        menuNoteActive = !menuNoteActive;
        cc.enabled = !cc.enabled;
    }
    // Update is called once per frame
    void Update()
    {
                
    }

    public void AddObjectToList(string value, int index)
    {
        uic.ShowMsj("You picked up " + value);
        ListaDeProd.Add(index, value);
        foreach(GameObject go in recolectables)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                break;
            }                
        }
    }
    public void AddObjectToListLore(string value, int index)
    {
        uic.ShowMsj(value);
        ListaDeProdLore.Add(index, value);
    }

    public bool ContainsKey(int index)
    {
        return ListaDeProd.ContainsKey(index);
    }

    public void AddNoteToList(string value, int indexNote)
    {
        uic.ShowMsj("You picked up a note");
        goListaDeNotas[indexNote].gameObject.SetActive(true);
        ListaDeNotas.Add(indexNote, value);
    }

    public string GetNota(int index)
    {
        return ListaDeNotas[index];
    }

    public void ShowTextNota()
    {
        txtNota.text = GetNota(0);
    }
    public void ShowTextNota2()
    {
        txtNota.text = GetNota(1);
    }
    public void ShowTextNota3()
    {
        txtNota.text = GetNota(2);
    }
    public void ShowTextNota4()
    {
        txtNota.text = GetNota(3);
    }
    public void ShowTextNota5()
    {
        txtNota.text = GetNota(4);
    }
    public void ShowTextNota6()
    {
        txtNota.text = GetNota(5);
    }
    public void ShowTextNota7()
    {
        txtNota.text = GetNota(6);
    }
    public void ShowTextNota8()
    {
        txtNota.text = GetNota(7);
    }
}
