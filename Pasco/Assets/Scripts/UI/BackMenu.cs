using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class BackMenu : MonoBehaviour
{
    
    public Button btnExits;
    // Start is called before the first frame update
    void Start()
    {
        btnExits.onClick.AddListener(LoadMenu);
    }
    void LoadMenu()
    {
        SceneManager.LoadScene("MenuInicio");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
