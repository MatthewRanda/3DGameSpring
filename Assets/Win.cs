using UnityEngine;

public class Win : MonoBehaviour
{                //changed from OnEnter
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Win(); 
        }
    
    }


}
