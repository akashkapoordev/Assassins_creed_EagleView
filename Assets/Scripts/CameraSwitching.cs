using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using StarterAssets;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera playerCamera;
    [SerializeField] private CinemachineVirtualCamera birdCamera;
    [SerializeField] private ThirdPersonController thirdPersonController;
    [SerializeField] private BirdController birdController;

    private ICamera normalCamera;
    private ICamera eagalCamera;

    private ICamera currentMode;

    private void Awake()
    {
        normalCamera = new NormalCamera(); ;
        eagalCamera = new EagleVision();
    }

    private void Start()
    {
        currentMode = normalCamera;
        currentMode.SwitchCamera(playerCamera);
        SetController(true);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchCameraToPlayer();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCameraToBird();
        }
    }


    private void SwitchCameraToPlayer()
    {
        eagalCamera.setInActiveCamera(birdCamera);
        currentMode = normalCamera;
        currentMode.SwitchCamera(playerCamera);
        SetController(true);
    }

    private void SwitchCameraToBird()
    {
        normalCamera.setInActiveCamera(playerCamera);
        currentMode = eagalCamera;
        currentMode.SwitchCamera(birdCamera);
        SetController(false);
    }


    private void SetController(bool isPlayerActive)
    {
        thirdPersonController.enabled = isPlayerActive;
        birdController.enabled = !isPlayerActive;
    }

}
