using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaking : MonoBehaviour
{
    public float magnitud = 4f;
    public float duration = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shake()
    {
        StartCoroutine(ShakingCam(magnitud, duration));
    }

    IEnumerator ShakingCam(float magnitud, float duration)
    {
        //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<>
        Vector3 posOriginal = GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition;
        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitud;
            float y = Random.Range(-1f, 1f) * magnitud;

            GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = new Vector3(x, y, posOriginal.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        GameObject.FindGameObjectWithTag("MainCamera").transform.localPosition = posOriginal;
    }
}
