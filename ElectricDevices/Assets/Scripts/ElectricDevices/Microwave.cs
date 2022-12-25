using Assets.Scripts.Infastructure;
using System;
using UnityEngine;

namespace Assets.Scripts.ElectricDevices
{
    public class Microwave : ElectricDeviceBase
    {
        #region Editor

        [SerializeField]
        private float _timerInSeconds;

        #endregion

        #region Fields

        private TimerService _timerService;

        #endregion

        #region Methods

        protected override void CheckIfDeviceOn(bool isOn)
        {
            if (!isOn)
            {
                SetisOn(true);
                SetTimer();
            }
        }

        private void SetTimer()
        {
            _timerService = new TimerService(_timerInSeconds);

            _timerService.TimerBegin += OnTimerBegin;
            _timerService.TimerEnd += OnTimerEnd;

            _timerService.RunTimer();
        }

        private void OnTimerEnd()
        {
            SetisOn(false);
            Debug.Log($"Microwave: [Bip Bip Bipppp], Is On: {IsOn}");
        }

        private void OnTimerBegin()
        {
            
        }

        #endregion
    }
}
