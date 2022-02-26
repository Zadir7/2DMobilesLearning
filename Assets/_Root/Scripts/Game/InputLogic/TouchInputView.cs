using JoostenProductions;
using UnityEngine;

namespace Game.InputLogic
{
    internal class TouchInputView : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 10;
        
        private void Start() => UpdateManager.SubscribeToUpdate(Move);

        private void OnDestroy() => UpdateManager.UnsubscribeFromUpdate(Move);

        private void Move()
        {
            float moveValue = Time.deltaTime;
            
            if (Input.touchCount > 0)
            {
                var touch = Input.GetTouch(0);
                if (touch.pressure > 0)
                    OnRightMove(moveValue * _inputMultiplier);
            }
            else
            {
                OnLeftMove(moveValue);
            }
        }
    }
}