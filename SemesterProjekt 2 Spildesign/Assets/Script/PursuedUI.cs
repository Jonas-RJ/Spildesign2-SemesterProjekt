using UnityEngine;

public class PursuedUI : MonoBehaviour
{
    [SerializeField] Sprite question;
    [SerializeField] Sprite exclamation;
    [SerializeField] GameObject go;
    [SerializeField] SpriteRenderer sign;

    public void Start()
    {
        go.SetActive(false);
    }

    public void Disable()
    {
        go.SetActive(false);
    }

    public void Question() 
    {
        go.SetActive (true);
        sign.sprite = question;
    }

    public void Exclamation()
    {
        sign.sprite = exclamation;
    }
}
