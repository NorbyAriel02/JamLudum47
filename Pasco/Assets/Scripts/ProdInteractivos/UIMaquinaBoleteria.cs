using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaquinaBoleteria : MonoBehaviour
{
    public GameObject tren;
    public GameObject TimeScaleHelper;
    //Esto activa el trigger que carga la segunda scena
    //public GameObject trigger;    
    public List<Button> listaBotenes;
    public Text txtCodigo;
    public string Codigo;
    public Animator animator;
    public AudioSource sonido;
    bool AccionaTablero;
    // Start is called before the first frame update
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

    private void OnDisable()
    {
        Instantiate(TimeScaleHelper);
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
            animator.SetBool("IsActive", true);
            sonido.Play();
            tren.SetActive(true);
            MiDisenabled();
        }
        
    }
}
