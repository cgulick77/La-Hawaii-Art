using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Inputts
   private ObjectRotationInput objectRotationInput;
   public InputAction playerMovement;
   private CharacterController controller;
   private Vector3 playerVelocity;
    
   private float playerSpeed = 10;
   public Rigidbody playerRb;

  

    private void Start() {
        controller = GetComponent<CharacterController>();
    }
   private void OnEnable() {
    playerMovement.Enable();

   }

   private void OnDisable() {
    playerMovement.Disable();
   }

    void Update() 
    {
    
     Vector3 moveDirection = Vector3.zero;
     
    moveDirection = playerMovement.ReadValue<Vector2>();
     transform.Translate(moveDirection * playerSpeed * Time.deltaTime);
   

    }

    
    

    
   

}
