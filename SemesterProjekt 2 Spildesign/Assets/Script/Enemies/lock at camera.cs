using UnityEngine;

public class lockatcamera : MonoBehaviour
{
  
    [SerializeField] Camera _camera;


    private void LateUpdate()
    {
        Vector3 cameraPosition = _camera.transform.position;

        cameraPosition.y = transform.position.y;

        transform.LookAt(cameraPosition);

        transform.Rotate(0f, 180f, 0f);
    }
}
