using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 1; // select distance = 10 units from the camera
        //Debug.Log(Camera.main.ScreenToWorldPoint(mousePos));
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = cursorPos;
    }
}
