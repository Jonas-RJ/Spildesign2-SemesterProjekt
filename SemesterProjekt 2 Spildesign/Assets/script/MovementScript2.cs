using UnityEngine;
using UnityEngine.InputSystem;

public class MovementScript2 : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    private Vector2 movementInput;
    private Rigidbody rb;
    [SerializeField] CapsuleCollider capsuleCollider;



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

   }
