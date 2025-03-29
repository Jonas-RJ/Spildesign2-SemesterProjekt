using UnityEngine;
using UnityEngine.InputSystem;
public class movement : MonoBehaviour
{
    PlayerInput PlayerInput;

    InputAction moveAction;

    [SerializeField] float speed = 5;

    void Start()
    {
        PlayerInput = GetComponent<PlayerInput>();
        moveAction = PlayerInput.actions.FindAction("move");
    }

    private void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        //Debug.Log(moveAction.ReadValue<Vector2>());
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * Time.deltaTime * speed;
    }
}
