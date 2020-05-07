using System;
using AnnoMath.Vectors;

/// <summary>
/// AnnoMath library namespace with Figures 2D
/// </summary>
namespace AnnoMath.Figures2D
{
    /// <summary>
    /// 2D Triangle
    /// </summary>
    public partial class Triangle
    {
        /// <summary>
        /// Array of Triangle edges
        /// </summary>
        private float[] _edges;
        /// <summary>
        /// Triangle the shortest edge
        /// </summary>
        public float A
        {
            get
            {
                return this._edges[0];
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Triangle - edge 'A' must be greater than zero");
                }
                this._edges[0] = value;
                SortEdges();
            }
        }
        /// <summary>
        /// Triangle medium edge
        /// </summary>
        public float B
        {
            get
            {
                return this._edges[1];
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Triangle - edge 'B' must be greater than zero");
                }
                this._edges[1] = value;
                SortEdges();
            }
        }
        /// <summary>
        /// Triangle the longest edge
        /// </summary>
        public float C
        {
            get
            {
                return this._edges[2];
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Triangle - edge 'C' must be greater than zero");
                }
                this._edges[2] = value;
                SortEdges();
            }
        }
        /// <summary>
        /// Triangle position
        /// </summary>
        private Vector2 _position;
        /// <summary>
        /// Triangle position
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
                    throw new ArgumentNullException("Triangle - position cannot be null");
                }
                this._position = value;
            }
        }
        /// <summary>
        /// Type of Triangle by edges length
        /// </summary>
        public TriangleEdgeType triangleEdgeType { private set; get; }
        /// <summary>
        /// Type of Triangle by angle size
        /// </summary>
        public TriangleAngleType triangleAngleType { private set; get; }
    }
}
