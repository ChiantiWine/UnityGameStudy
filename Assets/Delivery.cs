using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool haspackage;
    [SerializeField] float destroyDelayTime = 0.1f;
    [SerializeField] Color32 hasPackageColor = new Color32(0, 1, 0, 1);
    [SerializeField] Color32 notHasPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    void Start() 
    {
       spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("The car has Collided");
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        // if(Tag : package인 아이템을 부딪쳤나?)
        // {
        //      콘솔창에 "package picked up(아이템을 먹었다.)라고 출력되어야함.
        // }

        if(other.CompareTag("Package") && !haspackage)
        {
            Debug.Log("Package picked up");
            haspackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject,  destroyDelayTime);
        }  

        if(other.CompareTag("Customer") && haspackage)
        {
            Debug.Log("The customer received the package.");
            haspackage = false;
            spriteRenderer.color = notHasPackageColor;
        }
    }

}
