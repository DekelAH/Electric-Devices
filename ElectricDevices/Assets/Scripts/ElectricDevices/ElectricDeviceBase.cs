using UnityEngine;

namespace Assets.Scripts.ElectricDevices
{
    public abstract class ElectricDeviceBase : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private string _deviceName;

        [SerializeField]
        private int _consumingWatt;

        [SerializeField]
        private Color _color;

        [SerializeField]
        private bool _isOn;

        #endregion

        #region Methods

        public void TurnOnDevice()
        {
            CheckIfDeviceOn(_isOn);
        }

        public virtual string PrintDeviceSpec()
        {
            var deviceSpecString = $"Device: {_deviceName}, Consuming Volt: {_consumingWatt}, Color: {_color.ToString()}, Is On: {_isOn}";
            return deviceSpecString;
        }

        protected void SetisOn(bool isOn)
        {
            _isOn = isOn;
        }

        protected abstract void CheckIfDeviceOn(bool isOn);

        #endregion

        #region Properties

        public string DeviceName => _deviceName;
        public int ConsumingWatt => _consumingWatt;
        public Color Color => _color;
        public bool IsOn => _isOn;

        #endregion
    }
}
