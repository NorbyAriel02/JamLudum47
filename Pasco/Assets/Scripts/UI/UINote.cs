using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UINote : MonoBehaviour
{
    public GameObject timeScale;
    public string text;
    public Text txtNote;
    private void Start()
    {
        
    }
    private void OnEnable()
    {
        UIHelper.UIOpen();
    }
    private void OnDisable()
    {
        UIHelper.UIClose(timeScale);
    }
    public void Exit()
    {
        UIHelper.UIClose(timeScale);
        Cursor.visible = false;
        Destroy(gameObject);        
    }

}
