using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Score score;
    
    
    public GameObject playerCamera;
    public float ballDistPlayer = 1.75f;
    public bool holdingBall = true;
    public float throwingSpeed;
    public float ylowervalueBall =1f;
    public float upwardForce;
    public PlayerInputActions playerInputActions;
    public GameObject currentBall;
    public void Awake()
    {
    playerInputActions = new PlayerInputActions();
    playerInputActions.Player.ThrowBall.performed += ThrowingBall;
    playerInputActions.Player.Enable();
    }

    // Start is called before the first frame update
    public void Start()
    {
       currentBall.GetComponent<Rigidbody>().useGravity=false; 
       
    }

    // Update is called once per frame
    public void Update()
    {
        if (holdingBall)
        {
            Vector3 newPosition = playerCamera.transform.position + playerCamera.transform.forward * ballDistPlayer;
            newPosition.y -= ylowervalueBall;
            currentBall.transform.position = newPosition;
        }       
         
  
    }
    public void ThrowingBall(InputAction.CallbackContext context)
    {
       
            
        holdingBall =false;
        currentBall.GetComponent<Rigidbody>().useGravity= true;
        Vector3 throwForce = playerCamera.transform.forward * throwingSpeed;
        throwForce.y = upwardForce;
        currentBall.GetComponent<Rigidbody>().AddForce(throwForce);

        
        
        }
    
      



}
