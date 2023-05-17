using Enums;
using UnityEngine;

namespace Extensions
{
    public static class Rigidbody2dExtension
    {
        public static void SetVelocity(this Rigidbody2D rigidbody2d, Axis axis, float value)
        {
            var oldVelocity = rigidbody2d.velocity;
            var newVelocity =
                new Vector2(
                    axis == Axis.X ? value : oldVelocity.x,
                    axis == Axis.Y ? value : oldVelocity.y
                    );
            rigidbody2d.velocity = newVelocity;
        }
    }
}