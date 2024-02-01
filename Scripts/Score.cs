using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public ParticleSystem trailSystem;
    public GameObject trailObject;
    // Start is called before the first frame update
    void Start()
    {
        trailObject.SetActive(false);
        trailSystem =  GetComponent<ParticleSystem>();
    }
    
    public void Celebration()
    {
       trailObject.SetActive(true);
    }
   public void OnTriggerEnter(Collider other)
   {
       if (other.gameObject.tag == "ball")
       {
        Celebration();
       }
   }
}
