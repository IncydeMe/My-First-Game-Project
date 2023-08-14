using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]
    private InputAction action;

    private Animator animator;
    private bool vehicleCamera = true;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        action.performed += _ => SwitchState();
    }

    private void SwitchState()
    {
        if (vehicleCamera)
        {
            animator.Play("SecondCam");
        }
        else
        {
            animator.Play("VehicleCam");
        }
        vehicleCamera = !vehicleCamera;
    }

}
