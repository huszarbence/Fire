using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMover : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] float forceValue;

    Rigidbody thisRigidbody;
    
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        thisRigidbody.AddForce(Vector3.forward * forceValue, ForceMode.Impulse);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
