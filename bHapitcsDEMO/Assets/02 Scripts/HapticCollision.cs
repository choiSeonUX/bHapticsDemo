using Bhaptics.SDK2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint closestPoint = collision.contacts[0];
        float minDistance = Vector3.Distance(transform.position, closestPoint.point);

        foreach (ContactPoint contact in collision.contacts)
        {
            float distance = Vector3.Distance(transform.position, contact.point);
            if (distance < minDistance)
            {
                minDistance = distance;
                closestPoint = contact;
            }
        }
    }
    //private int[] CalculateMotorIntensities(Vector3 contactPoint)
    //{
    //    int[] motors = new int[40] { 40, 40, 40, 40,40,40};
    //    return motors;
    //}
}


