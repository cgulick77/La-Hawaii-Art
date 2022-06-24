using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private ObjectRotationInput objectRotationInput;
    private ObjectRotationInput.ObjectRotationActions movement;
    private PlayerMovement playerMovement;
    private PlayerLook look;
    // Start is called before the first frame update
    void Awake()
    {
        objectRotationInput = new ObjectRotationInput();
        movement = objectRotationInput.ObjectRotation;
        playerMovement = GetComponent<PlayerMovement>();
        look = GetComponent<PlayerLook>();
    }

   void LateUpdate()
    {
       look.ProcessLook(movement.Look.ReadValue<Vector2>());
   }
    void FixedUpdate()
    {
        playerMovement.PlayerMove(movement.Movement.ReadValue<Vector2>());
    }
    private void OnEnable() 
    {
        movement.Enable();
    }
    private void OnDisable()
    {
        movement.Disable();
    }
}
