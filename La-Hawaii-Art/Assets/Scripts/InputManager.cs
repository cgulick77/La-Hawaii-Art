using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private ObjectRotationInput objectRotationInput;
    private ObjectRotationInput.ObjectRotationActions movement;
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Awake()
    {
        objectRotationInput = new ObjectRotationInput();
        movement = objectRotationInput.ObjectRotation;
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
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
