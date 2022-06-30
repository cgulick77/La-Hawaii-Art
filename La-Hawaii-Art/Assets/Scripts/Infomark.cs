using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infomark : MonoBehaviour
{
    public GameObject qM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        qM.transform.Rotate(0f,.5f,0f);
    }

    void OnTriggerEnter(Collider other) {
         if(other.CompareTag("Player"))
        {
            qM.SetActive(false);
        }
    }
}
