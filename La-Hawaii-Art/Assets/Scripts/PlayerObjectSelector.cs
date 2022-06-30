using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerObjectSelector : MonoBehaviour
{
    private ObjectRotationInput objectRotationInput;
    public GameObject rayStartPoint;
     private InputAction select;
     private bool mouseClicked;
    // Start is called before the first frame update
    void Awake()
    {
        objectRotationInput = new ObjectRotationInput();

    }

    private void OnEnable() {

    objectRotationInput.ObjectRotation.Select.performed += selectObj;
    objectRotationInput.ObjectRotation.Select.Enable();

    }

    private void OnDisable() {

    objectRotationInput.ObjectRotation.Select.Disable();

    }

   
    void FixedUpdate() {
        
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 60f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);

            if(hitInfo.collider.tag == "Interactable" && mouseClicked == true)
            {
                //objInteract(hitInfo.transform.gameObject);
               
            }
            else{
                  //bjDisable(hitInfo.transform.gameObject);
            }
        }
        else{
             Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.white);
           
        }

    }

    private void selectObj(InputAction.CallbackContext obj)
   {
     mouseClicked = true;
   }

   private void objInteract(GameObject pickObj)
   {
        if (pickObj.GetComponent<RotateObjectTest>())
        {
            RotateObjectTest rotateObjectTest = pickObj.GetComponent<RotateObjectTest>();
             rotateObjectTest.isSelected = true;
        }
   }

    private void objDisable(GameObject pickObj)
    {
        if (pickObj.GetComponent<RotateObjectTest>())
        {
            RotateObjectTest rotateObjectTest = pickObj.GetComponent<RotateObjectTest>();
             rotateObjectTest.isSelected = false;
        }
    }

}
