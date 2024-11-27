using UnityEngine;

public class Doriver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 0.1f;
    [SerializeField]float moveSpeed = 0.01f;

    void Start()
    {
        
        // transform.Rotate(Vector3.forward, Space.Self);
        
    }

   
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed; // 매프레임마다 새롭게 계산해야하기 때문에 Update에 씀
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0,  moveAmount, 0);
    }
}
