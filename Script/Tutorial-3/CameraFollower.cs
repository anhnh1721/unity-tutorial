using UnityEngine;

public class CameraFollower : MonoBehaviour {

    public Transform target;
    public Vector3 offset;

    public float smoothTime = 0.25f;
    public Vector3 velocity = Vector3.zero;

    //void Update () {
    //       transform.position = target.localPosition + offset;
    //}

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
