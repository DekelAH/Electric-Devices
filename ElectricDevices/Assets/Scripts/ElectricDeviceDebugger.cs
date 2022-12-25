using Assets.Scripts.ElectricDevices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricDeviceDebugger : MonoBehaviour
{
    #region Editor

    [SerializeField]
    private ElectricDeviceBase[] _devices;

    #endregion

    #region Methods

    public void PrintDevices()
    {
        foreach (var device in _devices)
        {
            device.TurnOnDevice();
            Debug.Log(device.PrintDeviceSpec());
        }

    }

    #endregion
}
