using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Infastructure
{
    public class TimerService
    {
        #region Events

        public event Action TimerBegin;
        public event Action TimerEnd;

        #endregion

        #region Fields

        private Coroutine _timerCoroutine;
        private readonly float _time;

        #endregion

        #region Constructors

        public TimerService(float time)
        {
            _time = time;
        }

        #endregion

        #region Methods

        public void RunTimer()
        {
            _timerCoroutine = CoroutineService.Instance.BeginCoroutine(TimerCoroutine(_time));
        }

        public void StopTimer()
        {
            CoroutineService.Instance.EndCoroutine(_timerCoroutine);
        }

        private IEnumerator TimerCoroutine(float time)
        {
            TimerBegin?.Invoke();

            yield return new WaitForSeconds(time);

            TimerEnd?.Invoke();
        }

        #endregion
    }
}
