using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFeedback : MonoBehaviour
{
    public float delay = 2f;
    public Text display;
    public Image bg;
    private float timer = 0;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            bg.gameObject.SetActive(false);
            display.gameObject.SetActive(false);
        }            
    }
    void Reset()
    {
        bg.gameObject.SetActive(true);
        display.gameObject.SetActive(true);        
        timer = delay;
    }
    public void PickUp(string value)
    {
        display.text = value;
        Reset();
    }

    public void Standing()
    {
        
        
    }


}
