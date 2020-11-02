using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outlines : MonoBehaviour
{
    public Material _material;
    public float scaleObject = 1;
    public float outlinesScaleFactor;
    public Color color1;
    public Color color2;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        CreateOutline();
    }

    void CreateOutline()
    {
        GameObject goOutline = new GameObject(gameObject.name + "_outlines");
        goOutline.transform.position = transform.position;
        goOutline.transform.localScale = new Vector3(scaleObject, scaleObject, scaleObject);
        goOutline.transform.rotation = transform.rotation;
        goOutline.transform.SetParent(transform);

        MeshFilter meshFilter = goOutline.AddComponent<MeshFilter>();
        meshFilter.mesh = GetComponent<MeshFilter>().mesh;

        renderer = goOutline.AddComponent<MeshRenderer>();
        renderer.material = _material;
        renderer.material.SetColor(name + "_outlineColor", color1);
        renderer.material.SetFloat(name + "_ScaleFactor", outlinesScaleFactor);
        renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;        
    }

    void Tild()
    {
        renderer.material.SetColor(name + "_outlineColor", Color.Lerp(color1, color2, Mathf.PingPong(Time.time, 1)));         
    }

    // Update is called once per frame
    void Update()
    {
        Tild();
    }
}
