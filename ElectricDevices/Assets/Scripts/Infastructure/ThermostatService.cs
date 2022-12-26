using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Infastructure
{
    public class ThermostatService
    {
        #region Events

        public event Action StartThermostat;
        public event Action EndThermostat;

        #endregion

        #region Fields

        private Coroutine _thermostatCoroutine;

        private const float MIN_DEGREES = 0;
        private readonly float _maxDegrees;
        private float _currentDegrees;

        #endregion

        #region Constructor

        public ThermostatService(float maxDegrees)
        {
            _maxDegrees = maxDegrees;
        }

        #endregion

        #region Methods

        public void RunThermostat()
        {
            _thermostatCoroutine = CoroutineService.Instance.BeginCoroutine(ThermostatCoroutine(MIN_DEGREES, _maxDegrees));
        }

        public void StopThermostat()
        {
            CoroutineService.Instance.EndCoroutine(_thermostatCoroutine);
        }

        private IEnumerator ThermostatCoroutine(float minDegrees, float maxDegrees)
        {
            float degrees = minDegrees;

            StartThermostat?.Invoke();

            while (degrees < maxDegrees)
            {
                degrees += 0.08f;
                _currentDegrees += degrees;

                yield return null;
            }

            EndThermostat?.Invoke();
        }

        #endregion

        #region Properties

        public float CurrentDegrees => _currentDegrees;

        #endregion
    }
}
