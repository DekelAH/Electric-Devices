using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ElectricDevices
{
    public class TV : ElectricDeviceBase
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
