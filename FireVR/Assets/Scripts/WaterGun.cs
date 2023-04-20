using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    [SerializeField]
    ParticleSystem waterVisual;
    [SerializeField]
    GameObject waterProxy;
    
    [SerializeField]
    public Transform  spawnPoint;
    

    private void Start() 
    {
        // Fetch Rigidbody
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) 
    {
        // replace keycode.g with conrtoller trigger
        if (Input.GetKeyDown(KeyCode.F) && other.GetComponent<OVRGrabbable>().isGrabbed)
        {
            waterVisual.Play();
        }
        else if (!other.GetComponent<OVRGrabbable>().isGrabbed)
        {
            waterVisual.Stop();
        }
    }

    private void Shoot()
    {
        Instantiate(waterProxy, spawnPoint);
        

        // Inkább magára a game objectre rakd a mozgató kódot ;)
    }
    
}
