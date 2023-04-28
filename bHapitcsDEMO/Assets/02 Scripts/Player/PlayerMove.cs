using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 1f;
    [SerializeField] private float runSpeed = 3f;
    private Rigidbody rigidbody;
    private Animator animator; 
    private bool isRunning = false;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();  
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float currentSpeed = isRunning ? runSpeed :  walkSpeed;
        isRunning = Input.GetKey(KeyCode.LeftShift);

#if UNITY_EDITOR 
       
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(moveHorizontal, 0, moveVertical).normalized;
            rigidbody.velocity = direction * currentSpeed;
       
#endif

        if (isRunning)
            animator.SetTrigger("Running");
        else
            animator.SetTrigger("Walking");
    }
}
