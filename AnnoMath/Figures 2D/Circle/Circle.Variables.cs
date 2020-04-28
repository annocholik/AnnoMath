using System;
using AnnoMath.Vectors;

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
        /// Circle radius
        /// </summary>
        private float _radius;
        /// <summary>
        /// Circle radius
        /// </summary>
        public float radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Circle - radius must be greater or equal zero");
                }
                this._radius = value;
            }
        }
        /// <summary>
        /// Circle position
        /// </summary>
        private Vector2 _position;
        /// <summary>
        /// Circle position
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
                    throw new ArgumentNullException("Circle - position cannot be null");
                }
                this._position = value;
            }
        }
    }
}
