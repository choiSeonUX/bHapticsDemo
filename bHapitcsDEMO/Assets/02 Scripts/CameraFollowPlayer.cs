using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    private float cameraRotationSpeed = 5.0f;
    private float cameraXRotation = 0f;
    private float cameraYRotaton = 0f;

    private void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.y, transform.rotation.eulerAngles.z);

        float mouseX = Input.GetAxis("Mouse X") * cameraRotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * cameraRotationSpeed;

        cameraXRotation += mouseX;
        cameraYRotaton -= mouseY;
        transform.rotation = Quaternion.Euler(cameraXRotation, cameraYRotaton, 0f);
    }
}
