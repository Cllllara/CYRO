using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform targetTransform; //The object the camera will follow
    private Vector3 cameraFollowVelocity = Vector3.zero;

    public float cameraFollowSpeed = 0.2f;
    public float lookAngle; //cam look up and down
    public float pivotAngle; //Cam look left and right

    public void Awake()
    {
        targetTransform = FindObjectOfType<PlayerController>().transform;
    }
   public void FollowTarget(){

    Vector3 targetPosition = Vector3.SmoothDamp
    (transform.position, targetTransform.position, ref cameraFollowVelocity, cameraFollowSpeed);

    transform.position = targetPosition;

   }

public void RotateCamera()
{
    //lookAngle = lookAngle + (mouseXInput * cameraLookSpeed);
    //pivotAngle = pivotAngle - (mouseYInput * cameraPivotSpeed);
}
   
}
