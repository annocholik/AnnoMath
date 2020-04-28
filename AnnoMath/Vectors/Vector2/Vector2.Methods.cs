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
        /// Create normalized Vector2
        /// </summary>
        /// <returns>Normalized Vector2</returns>
        public Vector2 Normal()
        {
            float magnitude = this.Magnitude();
            return (magnitude == 0) ? new Vector2() : this * (1 / magnitude);
        }

        /// <summary>
        /// Calculate Vector2 magnitude
        /// </summary>
        /// <returns>Value of Vector2 magnitude</returns>
        public float Magnitude()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        /// <summary>
        /// Calculate dot product for two vectors.
        /// </summary>
        /// <param name="vec">Second Vector2</param>
        /// <returns>Value of dot product</returns>
        public float Dot(Vector2 vec)
        {
            return this.x * vec.x + this.y * vec.y;
        }

        /// <summary>
        /// Calculate angle between two vectors
        /// </summary>
        /// <param name="vec">Second Vector2</param>
        /// <returns>Angle between two vectors in radian</returns>
        public float Angle(Vector2 vec)
        {
            float thisMagnitude = this.Magnitude();
            float vecMagnitude = vec.Magnitude();

            if (thisMagnitude == 0 && vecMagnitude == 0)
            {
                throw new DivideByZeroException("Vector2 - one of vectors have magnitude equal zero.");
            }

            float dotProduct = this.Dot(vec);

            return (float)Math.Acos(dotProduct / (thisMagnitude * vecMagnitude));
        }

        /// <summary>
        /// Create copy of Vector2
        /// </summary>
        /// <returns>Copy of Vector2</returns>
        public Vector2 Copy()
        {
            return new Vector2(this.x, this.y);
        }

        /// <summary>
        /// Return formatted string with Vector2 values
        /// </summary>
        /// <returns>Formatted string: [Vector2] X: {0:f}, Y: {1:f}</returns>
        public override string ToString()
        {
            return string.Format("[Vector2] X: {0:f}, Y: {1:f}", this.x, this.y);
        }
    }
}
