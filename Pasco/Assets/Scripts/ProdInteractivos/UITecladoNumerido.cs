using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITecladoNumerido : MonoBehaviour
{
    public GameObject TriggerObject;    
    public List<Button> listaBotenes;
    public Text txtCodigo;
    public string Codigo;
    bool AccionaTablero;
    
    void Start()
    {
        for (int x = 0; x <= 9; x++)
        {
            string value = x.ToString();
            listaBotenes[x].onClick.AddListener(delegate { BtnAdd(value); });
        }
        listaBotenes[10].onClick.AddListener(BtnDelete);
        listaBotenes[11].onClick.AddListener(BtnExit);
    }
    private void OnEnable()
    {
        MiEnabled();
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
        MiDisenabled();
    }
    void MiEnabled()
    {
        GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<GameCreator.Characters.PlayerCharacter>()
            .enabled = false;
        Cursor.visible = true;
    }
    void MiDisenabled()
    {
        gameObject.SetActive(false);
        GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<GameCreator.Characters.PlayerCharacter>()
            .enabled = true;
        GameObject.
            FindGameObjectWithTag("MainCamera").
            GetComponent<GameCreator.Camera.CameraController>()
            .enabled = true;
        Cursor.visible = false;
    }
    void Update()
    {
        if (Codigo.Equals(txtCodigo.text.Trim()))
        {
            TriggerObject.SetActive(true);
            MiDisenabled();
        }
    }
}
