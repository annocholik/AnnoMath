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
        /// Types of Triangles by edges length
        /// </summary>
        public enum TriangleEdgeType
        {
            IsoscelesTriangle,
            EquilateralTriangle,
            PolygonalTriangle
        }

        /// <summary>
        /// Types of Triangles by angle size
        /// </summary>
        public enum TriangleAngleType
        {
            RightAngledTriangle,
            AcuteAngledTriangle,
            ObtuseAngledTriangle
        }

        public enum TriangleEdgeSize
        {
            Shortest,
            Medium,
            Longest
        }
    }
}
