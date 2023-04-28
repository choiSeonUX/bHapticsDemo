using UnityEngine;
using Bhaptics.SDK2; 

public class bHapticsEffect : MonoBehaviour
{

    [SerializeField] Transform objectTransform;
    private float minDistance = 1.0f;
    private float maxDistance = 10.0f;
    private float hapticsPower = 0; 
    public void CheckDistance()
    {
       float distance = Mathf.Clamp(hapticsPower, minDistance, maxDistance);

        ++hapticsPower; 
    }
}
