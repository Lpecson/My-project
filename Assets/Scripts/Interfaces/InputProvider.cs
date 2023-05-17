using Enums;
namespace Interfaces
{
    public interface InputProvider
    {
        public float GetAxis(Axis axis);
        public bool GetActionPressed(InputAction action);
    }
}