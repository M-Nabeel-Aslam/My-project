using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FirstPersonController : MonoBehaviour
{
   
    void OnTriggerEnter(Collider collision)
    {
        Debug.LogError("OnTriggerEnter");
        if (collision.transform.tag == "Items")
        {
            
            Debug.LogError("OnTriggerEnter Items");
        }

    }


    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.LogError("OnCollisionEnter");
        if (collision.transform.tag == "Items")
        {
           
            Debug.LogError("OnCollisionEnter Items");
 
        }
    }


}

