using System;
using AnnoMath.Vectors;

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
        /// Squere radius
        /// </summary>
        private float _edge;
        /// <summary>
        /// Squere radius
        /// </summary>
        public float edge
        {
            get
            {
                return this._edge;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Squere - edge must be greater or equal zero");
                }
                this._edge = value;
            }
        }
        /// <summary>
        /// Squere position
        /// </summary>
        private Vector2 _position;
        /// <summary>
        /// Squere position
        /// </summary>
        public Vector2 position
        {
            get
            {
                return this._position;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Squere - position cannot be null");
                }
                this._position = value;
            }
        }
    }
}
