using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    /*static InputManager instance;

    public static InputManager Instance
    {
        get { return instance; }
    }
    PlayerInput playerinput;

    GameControls Controls;
    bool sprint;

    private void Awake()
    {
        if (instance != null && instance==this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        Controls = new GameControls();

        Controls.Player.Sprint.performed += SprintPerformed;
        Controls.Player.Sprint.canceled += SprintCanceled;
    }

    public bool IsSprint()
    {
        return sprint;
    }

    void SprintPerformed(InputAction.CallbackContext context)
    {
        sprint = true;
    }

    void SprintCanceled(InputAction.CallbackContext context)
    {
        sprint = false;
    }
    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.OnDisable();
    }*/
}
