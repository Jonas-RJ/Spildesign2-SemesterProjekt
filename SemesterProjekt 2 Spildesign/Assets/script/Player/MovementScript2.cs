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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(movementInput.x * moveSpeed, rb.linearVelocity.y, movementInput.y * moveSpeed);

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

}
