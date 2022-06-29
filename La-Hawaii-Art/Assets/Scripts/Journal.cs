using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Journal : MonoBehaviour
{
    public GameObject[] journalPages;
    private ObjectRotationInput objectRotationInput;
    private InputAction journalControls;
    private GameObject currentPage, next,prev;
    public int pageNum;
    public bool active;

    



    void Awake() {
        pageNum = 0;
        
        objectRotationInput = new ObjectRotationInput();
         GameObject cover = journalPages[pageNum];
         currentPage = cover;
         if (active)
         {
            currentPage.SetActive(true);
         }
         

        
    }

    // Update is called once per frame
    void OnEnable() {
        objectRotationInput.ObjectRotation.JournalPagesControlsLeft.performed += journalLeft;
        objectRotationInput.ObjectRotation.JournalPagesControlsLeft.Enable();

        objectRotationInput.ObjectRotation.JournalPagesControlsRight.performed += journalRight;
        objectRotationInput.ObjectRotation.JournalPagesControlsRight.Enable();
    }

    void OnDisable() {
         objectRotationInput.ObjectRotation.JournalPagesControlsLeft.Disable();
         objectRotationInput.ObjectRotation.JournalPagesControlsRight.Disable();
    }

    private void journalLeft(InputAction.CallbackContext obj)
    {
        if (active)
        {
            if (pageNum > 0)
        {
            Debug.Log("Left Page");
            pageNum -=1;
            next = currentPage;
            currentPage = journalPages[pageNum];
            currentPage.SetActive(true);
            next.SetActive(false);
            Debug.Log(pageNum);
        }
        }
        
        
    }   

    private void journalRight(InputAction.CallbackContext obj)
    {
        if (active)
        {
             if (pageNum < journalPages.Length -1)
        {
            pageNum +=1;
            prev = currentPage;
            currentPage = journalPages[pageNum];
            currentPage.SetActive(true);
            prev.SetActive(false);
            Debug.Log(pageNum);
        }
        }
     
    }
}
