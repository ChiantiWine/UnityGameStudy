using Unity.VisualScripting;
using UnityEngine;

public class Consition : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("The car has Collided");
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Start Line pass");    
    }
}
