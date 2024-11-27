using UnityEngine;

public class Doriver : MonoBehaviour
{
    
    void Start()
    {
        
        // transform.Rotate(Vector3.forward, Space.Self);
        
    }

   
    void Update()
    {
        // transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, 0.1f, 0);
    }
}
