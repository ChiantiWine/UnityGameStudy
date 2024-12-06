using UnityEngine;

public class Doriver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 20f;

    void Start()
    {
        
        // transform.Rotate(Vector3.forward, Space.Self);
        
    }

   
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; // 매프레임마다 새롭게 계산해야하기 때문에 Update에 씀
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; // Time.deltaTime을 적용해서 각 프레임이 실행되는 데 시간이 얼마나 소요되는지 알려줌
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0,  moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Boost"))
        {
            // Debug.Log("BBBBoost!!!");
            moveSpeed = boostSpeed;
        }    
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
    }
}
