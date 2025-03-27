using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class EagleVision : ICamera
{
    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        camera.m_Lens.FieldOfView = 25;
    }
}
