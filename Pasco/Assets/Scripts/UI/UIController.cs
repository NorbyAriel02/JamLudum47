using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEditor.PackageManager.UI;

public class UIController : MonoBehaviour
{
    public Text textMsj;    
    public Text TxtNota;
    public float timer = 5;
    float delay = 0;
    public PlayerInteraction pi;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (delay < 0)
            textMsj.enabled = false;

        delay -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.I))
        {
            pi.ActiveBGNote();
            Cursor.visible = !Cursor.visible;
        }
    }

    public void ShowMsj(string value)
    {
        textMsj.text = value;
        textMsj.enabled = true;
        delay = timer;
    }
}
