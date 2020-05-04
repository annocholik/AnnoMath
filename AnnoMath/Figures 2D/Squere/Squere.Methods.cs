using System;

/// <summary>
/// AnnoMath library namespace with Figures 2D
/// </summary>
namespace AnnoMath.Figures2D
{
    /// <summary>
    /// 2D Squere
    /// </summary>
    public partial class Squere
    {
        /// <summary>
        /// Calculate Squere field
        /// </summary>
        /// <returns>Squere field</returns>
        public float Field()
        {
            return this._edge * this._edge;
        }

        /// <summary>
        /// Calculate Squere circumference
        /// </summary>
        /// <returns>Squere circumference</returns>
        public float Circumference()
        {
            return 4f * this._edge;
        }

        /// <summary>
        /// Calculate Squere height
        /// </summary>
        /// <returns>Squere height</returns>
        public float Height()
        {
            return this._edge;
        }

        /// <summary>
        /// Calculate Squere diagonal
        /// </summary>
        /// <returns>Squere diagonal</returns>
        public float Diagonal()
        {
            return this._edge * (float)Math.Sqrt(2f);
        }
    }
}
