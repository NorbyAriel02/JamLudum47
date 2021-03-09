using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UINote : MonoBehaviour
{
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
        UIHelper.UIClose();
    }
    public void Exit()
    {
        gameObject.SetActive(false);
    }

}
