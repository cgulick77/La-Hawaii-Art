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
    public GameObject Questionmark, spawner;
    [SerializeField] LayerMask layerMask;

    



    void Awake() {
        pageNum = 0;
        
        objectRotationInput = new ObjectRotationInput();
         GameObject cover = journalPages[pageNum];
         currentPage = cover;
        
         

        
    }
    
     void FixedUpdate() {
        //Starts the journasl on the first page, checks if the journal is active
         if (active)
         {
            currentPage.SetActive(true);
         }

         if(Physics.Raycast(spawner.transform.position, spawner.transform.TransformDirection(Vector3.up), out RaycastHit hitInfo, 20f, layerMask))
         {
            Debug.DrawRay(spawner.transform.position, spawner.transform.TransformDirection(Vector3.up) * 2f, Color.red);
         }
         else {
             Debug.DrawRay(spawner.transform.position, spawner.transform.TransformDirection(Vector3.up) * 2f, Color.green);
            StartCoroutine(spawnInfoMark());
         }

    }
    

    // Update is called once per frame
    void OnEnable() {
        objectRotationInput.ObjectRotation.JournalPagesControlsLeft.performed += journalLeft;
        objectRotationInput.ObjectRotation.JournalPagesControlsLeft.Enable();

        objectRotationInput.ObjectRotation.JournalPagesControlsRight.performed += journalRight;
        objectRotationInput.ObjectRotation.JournalPagesControlsRight.Enable();

        objectRotationInput.ObjectRotation.JournalExit.performed += journalExit;
        objectRotationInput.ObjectRotation.JournalExit.actionMap.Enable();

        objectRotationInput.ObjectRotation.GameExit.performed += exitGame;
        objectRotationInput.ObjectRotation.GameExit.Enable();

        
    }

    void OnDisable() {
         objectRotationInput.ObjectRotation.JournalPagesControlsLeft.Disable();
         objectRotationInput.ObjectRotation.JournalPagesControlsRight.Disable();
         objectRotationInput.ObjectRotation.JournalExit.actionMap.Disable();
         objectRotationInput.ObjectRotation.GameExit.Disable();
    }

    // Page functions
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
            //Debug.Log(pageNum);
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
            //Debug.Log(pageNum);
        }
        }
     
    }

    private void journalExit (InputAction.CallbackContext obj)
    {
        active = false;
        currentPage.SetActive(false);
        Debug.Log("Exit");
    }

    private void exitGame (InputAction.CallbackContext obj)
    {
        Application.Quit();
    }

    IEnumerator spawnInfoMark()
    {
        active = true;
        yield return new WaitForSeconds(1);
        Questionmark.SetActive(true);
        StopAllCoroutines();
    }

     
}
