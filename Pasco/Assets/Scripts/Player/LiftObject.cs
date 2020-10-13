using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LiftObject : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Hand") && Input.GetKey(KeyCode.E))
        {
            transform.parent = other.transform;
            transform.position = other.transform.position;
            rb.isKinematic = true;            
        }
        else
        {
            transform.parent = null;            
            rb.isKinematic = false;
        }
    }
}
