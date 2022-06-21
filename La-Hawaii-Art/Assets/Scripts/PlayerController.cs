using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Inputts
   private ObjectRotationInput objectRotationInput;
   public InputAction playerMovement;
    
   private float playerSpeed = 10;
   public Rigidbody playerRb;

   Vector2 moveDirection = Vector2.zero;

   private void OnEnable() {
    playerMovement.Enable();

   }

   private void OnDisable() {
    playerMovement.Disable();
   }

    void Update() 
    {
    
    moveDirection = playerMovement.ReadValue<Vector2>();
   

    }

    private void FixedUpdate() {
        transform.Translate(moveDirection * playerSpeed * Time.deltaTime);
    }
   

}
