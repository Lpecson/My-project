using UnityEngine;
using System.Collections.Generic;
using Enums;
using Interfaces;
namespace Behaviors.InputSystems
{
    public class PlayerInputProvider : MonoBehaviour, InputProvider
    {
        private const string JumpButton = "Jump";
        private const string MeleeButton = "Melee";
        private const string RangedButton = "Ranged";
        private HashSet<InputAction> requestedActions = new HashSet<InputAction>();
        public float GetAxis(Axis axis)
        {
            return Input.GetAxisRaw(axis.ToUnityAxis());
        }

        public bool GetActionPressed(InputAction action)
        {
            return requestedActions.Contains(action);
        }

        private void Update()
        {
            CaptureInput();
        }

        private void CaptureInput()
        {
            if(Input.GetButtonDown(JumpButton))
            {
                requestedActions.Add(InputAction.Jump);
            }
            if(Input.GetButtonUp(JumpButton))
            {
                requestedActions.Remove(InputAction.Jump);
            }
            
            if(Input.GetButtonDown(MeleeButton))
            {
                requestedActions.Add(InputAction.Melee);
            }
            if(Input.GetButtonUp(MeleeButton))
            {
                requestedActions.Remove(InputAction.Melee);
            }
            
            if(Input.GetButtonDown(RangedButton))
            {
                requestedActions.Add(InputAction.Ranged);
            }
            if(Input.GetButtonUp(RangedButton))
            {
                requestedActions.Remove(InputAction.Ranged);
            }
        }
    }
}