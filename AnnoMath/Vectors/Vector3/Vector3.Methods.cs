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
        /// Create normalized Vector3
        /// </summary>
        /// <returns>Normalized Vector3</returns>
        public Vector3 Normal()
        {
            float magnitude = this.Magnitude();
            return (magnitude == 0) ? new Vector3() : this * (1 / magnitude);
        }

        /// <summary>
        /// Calculate Vector3 magnitude
        /// </summary>
        /// <returns>Value of Vector3 magnitude</returns>
        public float Magnitude()
        {
            return (float)Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        /// <summary>
        /// Calculate dot product for two vectors.
        /// </summary>
        /// <param name="vec">Second Vector3</param>
        /// <returns>Value of dot product</returns>
        public float Dot(Vector3 vec)
        {
            return this.x * vec.x + this.y * vec.y + this.z * vec.z;
        }

        /// <summary>
        /// Calculate angle between two vectors
        /// </summary>
        /// <param name="vec">Second Vector3</param>
        /// <returns>Angle between two vectors in radian</returns>
        public float Angle(Vector3 vec)
        {
            float thisMagnitude = this.Magnitude();
            float vecMagnitude = vec.Magnitude();

            if(thisMagnitude == 0 && vecMagnitude == 0)
            {
                throw new DivideByZeroException("Vector3 - one of vectors have magnitude equal zero.");
            }

            float dotProduct = this.Dot(vec);

            return (float)Math.Acos(dotProduct / (thisMagnitude * vecMagnitude));
        }

        /// <summary>
        /// Calculate cross product for two vectors.
        /// </summary>
        /// <param name="vec">Second Vector3</param>
        /// <returns>Value of cross product</returns>
        public Vector3 Cross(Vector3 vec)
        {
            return new Vector3(this.y * vec.z - this.z * vec.y, this.z * vec.x - this.x * vec.z, this.x * vec.y - this.y * vec.x);
        }

        /// <summary>
        /// Create copy of Vector3
        /// </summary>
        /// <returns>Copy of Vector3</returns>
        public Vector3 Copy()
        {
            return new Vector3(this.x, this.y, this.z);
        }

        /// <summary>
        /// Return formatted string with Vector3 values
        /// </summary>
        /// <returns>Formatted string: [Vector3] X: {0:f}, Y: {1:f}, Z: {1:f}</returns>
        public override string ToString()
        {
            return string.Format("[Vector3] X: {0:f}, Y: {1:f}, Z: {1:f}", this.x, this.y, this.z);
        }
    }
}
