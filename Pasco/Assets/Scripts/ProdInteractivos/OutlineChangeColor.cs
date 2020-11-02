using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class OutlineChangeColor : MonoBehaviour
{
    public Material mat;
    public float delay = 1;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            timer = delay;
            Color color = mat.GetColor("_OutlineColor");
            
            if (color != null)
            {
                color = Random.ColorHSV();                
                mat.SetColor("_OutlineColor", color);
            }
        }
    }
}
