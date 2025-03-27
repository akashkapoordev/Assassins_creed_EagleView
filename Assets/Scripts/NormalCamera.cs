using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class NormalCamera : ICamera
{
    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        camera.m_Lens.FieldOfView = 40;
    }
}
