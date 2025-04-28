using System;
using UnityEngine;

public class TemporaryDestroy : MonoBehaviour
{

public GameObject interactible;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            interactible.SetActive(false);
            print("cheeseburger");
        }
    }
   

}
