using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // Gemi (Cube) referansı
    public Vector3 offset = new Vector3(0, 5, -10);

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}
