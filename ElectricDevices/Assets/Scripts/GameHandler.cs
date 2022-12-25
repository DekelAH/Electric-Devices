using UnityEngine;

namespace Assets.Scripts
{
    public class GameHandler : MonoBehaviour
    {
        #region Editor

        [SerializeField]
        private ElectricDeviceDebugger _electricDeviceDebugger;

        #endregion

        #region Methods

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _electricDeviceDebugger.PrintDevices();
            }
        }

        #endregion
    }
}
