using Assets.Scripts.Infastructure;
using System;
using UnityEngine;

namespace Assets.Scripts.ElectricDevices
{
    public class Kettle : ElectricDeviceBase
    {
        #region Editor

        [SerializeField]
        private float _maxDegrees;

        #endregion

        #region Fields

        private ThermostatService _thermostatService;

        #endregion

        #region Methods

        protected override void CheckIfDeviceOn(bool isOn)
        {
            if (!isOn)
            {
                SetisOn(true);
                SetThermostat();
            }
        }

        private void SetThermostat()
        {
            _thermostatService = new ThermostatService(_maxDegrees);

            _thermostatService.StartThermostat += OnStartThermostat;
            _thermostatService.EndThermostat += OnEndThermostat;

            _thermostatService.RunThermostat();
        }

        private void OnEndThermostat()
        {
            SetisOn(false);
            Debug.Log($"Kettle: [Boilinggg], Is On: {IsOn}");
        }

        private void OnStartThermostat()
        {
            
        }

        #endregion
    }
}
