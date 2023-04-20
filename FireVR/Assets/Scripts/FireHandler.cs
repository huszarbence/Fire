using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHandler : MonoBehaviour
{
    
    [SerializeField] float healthPoints;

    [SerializeField] ParticleSystem starterParticleSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        starterParticleSystem.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.collider.tag == "ProjectileWater")
        {
           healthPoints -= 1;
           CheckHealth();
        }
    }

    private void CheckHealth()
    {
        if (healthPoints <= 0.0f)
        {
            starterParticleSystem.Stop();
        }
    }
}
