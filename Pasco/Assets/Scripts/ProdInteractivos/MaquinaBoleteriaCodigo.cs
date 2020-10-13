using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;


public class MaquinaBoleteriaCodigo : MonoBehaviour
{        
    public GameObject panel;
    public List<Button> listaBotenes;
    public Text txtCodigo;
    public string Codigo;


    private bool AccionaTablero;    
    private MoveTrain moveTrain;
    private GameObject trigger;
    private Player player;
    
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
        trigger = GameObject.FindGameObjectWithTag("LOADSCENE");
        moveTrain = GameObject.FindGameObjectWithTag("TRAIN").GetComponent<MoveTrain>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
        player.ClosePanel();
    }
    void Update()
    {
        if (!AccionaTablero)
            panel.SetActive(false);
        
        if(Codigo.Equals(txtCodigo.text.Trim()))
        {
            trigger.GetComponent<BoxCollider>().enabled = true;
            moveTrain.LlamarTren();
            panel.SetActive(false);
            player.ClosePanel();
        }
    }

    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            AccionaTablero = true;
            panel.SetActive(true);
            player.OpenPanel();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            AccionaTablero = false;
            player.ClosePanel();
            panel.SetActive(false);
        }
    }
}
