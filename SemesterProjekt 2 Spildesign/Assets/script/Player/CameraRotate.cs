using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    [SerializeField]private int rotater = 0;

    public GameObject CharacterSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnJump()
    {
        if (rotater == 0)
        {
            transform.Rotate(50, 0, 0);
            transform.localPosition = new Vector3(0, 16, 0);
            print("Camera rotate up");
            print(rotater);
            rotater++;
            CharacterSprite.transform.Rotate(50, 0, 0);
        }
        else
        {
            transform.Rotate(-50, 0, 0);
            transform.localPosition = new Vector3(0, 11, -14);
            print("Camera rotate down");
            print(rotater);
            rotater--;
                        CharacterSprite.transform.Rotate(-50, 0, 0);

        }
    }
}
