using System;

/// <summary>
/// AnnoMath library namespace with Vectors
/// </summary>
namespace AnnoMath.Vectors
{
    /// <summary>
    /// 3D Vector 
    /// </summary>
    public partial class Vector3
    {
        /// <summary>
        /// Create new Vector3 with sumed values
        /// </summary>
        /// <param name="vec">First Vector3</param>
        /// <param name="vec2">Second Vector3</param>
        /// <returns>New Vector2 with sumed values</returns>
        public static Vector3 operator +(Vector3 vec, Vector3 vec2)
        {
            return new Vector3(vec.x + vec2.x, vec.y + vec2.y, vec.z + vec2.z);
        }

        /// <summary>
        /// Create a new Vector3 with subtracted values ​​
        /// </summary>
        /// <param name="vec">First Vector3</param>
        /// <param name="vec2">Second Vector3</param>
        /// <returns>New Vector3 with subtracted values</returns>
        public static Vector3 operator -(Vector3 vec, Vector3 vec2)
        {
            return new Vector3(vec.x - vec2.x, vec.y - vec2.y, vec.z - vec2.z);
        }

        /// <summary>
        /// Create a new Vector3 with multiplyed values by given multiplier​​
        /// </summary>
        /// <param name="vec">Vector3 which values will be multiplyed</param>
        /// <param name="multiplier">Multiplier</param>
        /// <returns>New Vector3 with multiplyed values</returns>
        public static Vector3 operator *(Vector3 vec, float multiplier)
        {
            return new Vector3(vec.x * multiplier, vec.y * multiplier, vec.z * multiplier);
        }

        /// <summary>
        /// Create a new Vector3 with divided values by given divider​​
        /// </summary>
        /// <param name="vec">Vector3 which values will be divided</param>
        /// <param name="multiplier">Divider</param>
        /// <returns>New Vector3 with multiplyed values</returns>
        public static Vector3 operator /(Vector3 vec, float divider)
        {
            if(divider == 0)
            {
                throw new DivideByZeroException("Vector3 - divider cannot be equal zero.");
            }
            return new Vector3(vec.x / divider, vec.y / divider, vec.z / divider);
        }

        /// <summary>
        /// Calculate dot product for two vectors.
        /// </summary>
        /// <param name="vec">First Vector3</param>
        /// <param name="vec2">Second Vector3</param>
        /// <returns>Value of dot product</returns>
        public static float operator *(Vector3 vec, Vector3 vec2)
        {
            return vec.Dot(vec2);
        }
    }
}
