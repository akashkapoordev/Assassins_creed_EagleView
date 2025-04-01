using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class EagleVision : ICamera
{
    private CinemachineVirtualCamera camera;


    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        this.camera = camera;
        setPriority();
    }


    private void setPriority()
    {
        camera.Priority = 1;
    }


    public void setInActiveCamera(CinemachineVirtualCamera inactiveCamera)
    {
        inactiveCamera.Priority = 0;
    }
}
