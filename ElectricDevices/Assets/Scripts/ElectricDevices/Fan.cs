using System;

namespace Assets.Scripts.ElectricDevices
{
    public class Fan : ElectricDeviceBase
    {
        #region Methods

        protected override void CheckIfDeviceOn(bool isOn)
        {
            if (!isOn)
            {
                SetisOn(true);
            }
            else
            {
                SetisOn(false);
            }
        }

        #endregion
    }
}
