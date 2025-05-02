using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript2 : MonoBehaviour
{
    //  public bool isRunning = Keyboard.current.leftShiftKey.isPressed;


    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movementInput;
    private Rigidbody rb;
    [SerializeField] CapsuleCollider capsuleCollider;
    [SerializeField] private float sprintSpeed = 20f;
    [SerializeField] private float normalSpeed = 5f;

    Animator animator;
    GameControls Input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(movementInput.x * moveSpeed, rb.linearVelocity.y, movementInput.y * moveSpeed);

        /*walking forward
        if ()
        {
            animator.SetBool("IsWalking", true);
        }
        else 
        {
            animator.SetBool("IsWalking", false);
        }

        // walking back
        if ()
        {
            animator.SetBool("WalkingBack", true);
        }
        else 
        {
            animator.SetBool("WalkingBack", false);
        }
        // walking left side
        if ()
        {
            animator.SetBool("WalkingLeft", true);
        }
        else 
        {
            animator.SetBool("WalkingLeft", false);
        }
        // walking right side
        if ()
        {
            animator.SetBool("WalkingRight", true);
        }
        else 
        {
            animator.SetBool("WalkingRight", false);
        }*/
    }


    public void OnMove(InputValue direction)
    {
        movementInput = direction.Get<Vector2>();
    }


    public void OnSprint()
    {
        /*  
           if (isRunning)
           {moveSpeed = sprintSpeed;
           }
           else
           { moveSpeed = normalSpeed;}
        */

        if (moveSpeed <= normalSpeed)
        {
            print("speed up");
            moveSpeed += sprintSpeed;
        }
        else
        {
            print("Slow down");
            moveSpeed = normalSpeed;
        }



    }

    void OnEnable()
    {
        Input.Player.Enable();
    }

    void OnDisable()
    {
        Input.Player.Disable();
    }

}
