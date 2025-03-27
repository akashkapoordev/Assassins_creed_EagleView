using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraSwitching : MonoBehaviour
{
    [SerializeField]private CinemachineVirtualCamera mainCamera;
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
        currentMode.SwitchCamera(mainCamera);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            currentMode = normalCamera;
            currentMode.SwitchCamera(mainCamera);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            currentMode = eagalCamera;
            currentMode.SwitchCamera(mainCamera);
        }
    }
}
