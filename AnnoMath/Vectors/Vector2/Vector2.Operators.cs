using System;

/// <summary>
/// AnnoMath library namespace with Vectors
/// </summary>
namespace AnnoMath.Vectors
{
    /// <summary>
    /// 2D Vector 
    /// </summary>
    public partial class Vector2
    {
        /// <summary>
        /// Create new Vector2 with sumed values
        /// </summary>
        /// <param name="vec">First Vector2</param>
        /// <param name="vec2">Second Vector2</param>
        /// <returns>New Vector2 with sumed values</returns>
        public static Vector2 operator +(Vector2 vec, Vector2 vec2)
        {
            return new Vector2(vec.x + vec2.x, vec.y + vec2.y);
        }

        /// <summary>
        /// Create a new Vector2 with subtracted values ​​
        /// </summary>
        /// <param name="vec">First Vector2</param>
        /// <param name="vec2">Second Vector2</param>
        /// <returns>New Vector2 with subtracted values</returns>
        public static Vector2 operator -(Vector2 vec, Vector2 vec2)
        {
            return new Vector2(vec.x - vec2.x, vec.y - vec2.y);
        }

        /// <summary>
        /// Create a new Vector2 with multiplyed values by given multiplier​​
        /// </summary>
        /// <param name="vec">Vector2 which values will be multiplyed</param>
        /// <param name="multiplier">Multiplier</param>
        /// <returns>New Vector2 with multiplyed values</returns>
        public static Vector2 operator *(Vector2 vec, float multiplier)
        {
            return new Vector2(vec.x * multiplier, vec.y * multiplier);
        }

        /// <summary>
        /// Create a new Vector2 with divided values by given divider​​
        /// </summary>
        /// <param name="vec">Vector2 which values will be divided</param>
        /// <param name="multiplier">Divider</param>
        /// <returns>New Vector2 with multiplyed values</returns>
        public static Vector2 operator /(Vector2 vec, float divider)
        {
            if(divider == 0)
            {
                throw new DivideByZeroException("Vector2 - divider cannot be equal zero.");
            }
            return new Vector2(vec.x / divider, vec.y / divider);
        }

        /// <summary>
        /// Calculate dot product for two vectors.
        /// </summary>
        /// <param name="vec">First Vector2</param>
        /// <param name="vec2">Second Vector2</param>
        /// <returns>Value of dot product</returns>
        public static float operator *(Vector2 vec, Vector2 vec2)
        {
            return vec.Dot(vec2);
        }
    }
}
