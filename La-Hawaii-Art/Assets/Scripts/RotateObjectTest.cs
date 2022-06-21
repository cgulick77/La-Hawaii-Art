using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateObjectTest : MonoBehaviour
{
    // Start is called before the first frame update
   private ObjectRotationInput objectRotationInput;
   private InputAction rotateHorizontal;
   private InputAction rotateVertical;

   private void Awake() {
    
    objectRotationInput = new ObjectRotationInput();

   }

   private void OnEnable() {
    
    // rotateHorizontal = objectRotationInput.ObjectRotation.RotateHorizontal;
    // rotateHorizontal.Enable();

    objectRotationInput.ObjectRotation.RotateHorizontal.performed += RotateH;
    objectRotationInput.ObjectRotation.RotateHorizontal.Enable();

    objectRotationInput.ObjectRotation.RotateVerticle.performed += RotateV;
    objectRotationInput.ObjectRotation.RotateVerticle.Enable();


   }

   private void OnDisable() {
    objectRotationInput.ObjectRotation.RotateHorizontal.Disable();
    objectRotationInput.ObjectRotation.RotateVerticle.Disable();
   }

   private void RotateH(InputAction.CallbackContext obj)
   {
        Debug.Log("Rotating Horizontally");
        transform.Rotate(0f,10.0f,0f);
   }

    private void RotateV(InputAction.CallbackContext obj)
   {
        Debug.Log("Rotating Vertically");
         transform.Rotate(0f,0f,10f);
   }
}
