using JoostenProductions;
using UnityEngine;

namespace Game.InputLogic
{
    internal class ArrowsInputView : BaseInputView
    {
        [SerializeField] private float _inputMultiplier = 10;

        private const string LeftArrow = "";
        
        private void Start() => UpdateManager.SubscribeToUpdate(Move);

        private void OnDestroy() => UpdateManager.UnsubscribeFromUpdate(Move);

        private void Move()
        {
            var axisOffset = Input.GetAxis("Horizontal");
            var inputValue = axisOffset * _inputMultiplier * Time.deltaTime;

            var inputAbs = Mathf.Abs(inputValue);
            var inputSign = Mathf.Sign(inputValue);
            
            if (inputSign < 0)
                OnLeftMove(inputAbs);
            else 
                OnRightMove(inputAbs);

        }
    }
}