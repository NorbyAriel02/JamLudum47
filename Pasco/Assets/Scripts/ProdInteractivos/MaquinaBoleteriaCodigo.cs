using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class MaquinaBoleteriaCodigo : MonoBehaviour
{
    public MoveTrain mt;
    public GameObject trigger;
    public GameObject panel;
    public List<Button> listaBotenes;
    public Text txtCodigo;
    public string Codigo;
    bool AccionaTablero;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x <= 9; x++)
        {
            string value = x.ToString();
            listaBotenes[x].onClick.AddListener(delegate { BtnAdd(value); });
        }
        listaBotenes[10].onClick.AddListener(BtnDelete);
        listaBotenes[11].onClick.AddListener(BtnExit);
        panel.SetActive(false);
    }
    void BtnAdd(string value)
    {
        txtCodigo.text += value;
    }
    void BtnDelete()
    {
        if (txtCodigo.text.Length > 1)
            txtCodigo.text = txtCodigo.text.Substring(0, txtCodigo.text.Length - 1);
        else
            txtCodigo.text = "";
    }
    void BtnExit()
    {
        panel.SetActive(false);
        Cursor.visible = !Cursor.visible;
    }
    void Update()
    {        
        if (AccionaTablero)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                panel.SetActive(true);
                Cursor.visible = !Cursor.visible;
            }
        }        
        
        if(Codigo.Equals(txtCodigo.text.Trim()))
        {
            trigger.SetActive(true);
            mt.LlamarTren();
            panel.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Si es el personaje el que esta en la escalerilla
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("PLayer llego");
            AccionaTablero = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("PLayer salio");
            AccionaTablero = false;
        }
    }
}
