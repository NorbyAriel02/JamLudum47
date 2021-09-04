using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Observador : MonoBehaviour
{
    public Image pointer;
    public Sprite point;
    public Sprite hand;
    public RectTransform rectImg;
    public LayerMask layer;
    public float maxDist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Observar();
    }
    

    void Observar()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDist, layer))
        {
            pointer.sprite = hand;
            rectImg.localScale = new Vector3(5, 5, 5);
        }
        else
        {
            pointer.sprite = point;
            rectImg.localScale = new Vector3(1, 1, 1);
        }
    }
}
