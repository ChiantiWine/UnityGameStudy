using UnityEngine;

public class Doriver : MonoBehaviour
{
    float steerSpeed = 0.1f;
    float moveSpeed = 0.01f;

    void Start()
    {
        
        // transform.Rotate(Vector3.forward, Space.Self);
        
    }

   
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
