using System;

/// <summary>
/// AnnoMath library namespace with Figures 2D
/// </summary>
namespace AnnoMath.Figures2D
{
	/// <summary>
    /// 2D Circle
    /// </summary>
    public partial class Circle
    {
        /// <summary>
        /// Calculate Circle field
        /// </summary>
        /// <returns>Circle field</returns>
        public float Field()
        {
            return (float)Math.PI * this._radius * this._radius;
        }

        /// <summary>
        /// Calculate Circle circumference
        /// </summary>
        /// <returns>Circle circumference</returns>
        public float Circumference()
        {
            return 2f * (float)Math.PI * this._radius;
        }

        /// <summary>
        /// Calculate Circle diameter
        /// </summary>
        /// <returns>Circle diameter</returns>
        public float Diameter()
        {
            return 2f * this._radius;
        }
    }
}
