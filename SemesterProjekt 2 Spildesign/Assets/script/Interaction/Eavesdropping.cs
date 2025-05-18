using UnityEngine;
using UnityEngine.UI;

public class Eavesdropping : MonoBehaviour
{

    public Button ListenIn;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ListenIn.gameObject.SetActive(true);
            print("Cheeseburger");
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            ListenIn.gameObject.SetActive(false);
        }
    }



    public void OverHearConversation()
    {
        


    }


}
