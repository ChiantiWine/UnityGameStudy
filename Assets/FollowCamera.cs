using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject cameraFollowObject;


    // 카메라의 위치가 자동차의 위치와 동일해야함. 
    void LateUpdate()
    {
        transform.position = cameraFollowObject.transform.position + new Vector3(0, 0, -10);
    }
}
