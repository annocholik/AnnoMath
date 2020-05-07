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
        /// Default constructor, where radius is set one and position is set as default Vector2.
        /// </summary>
        public Circle()
        {
            this.radius = 1f;
            this.position = new Vector2();
        }

        /// <summary>
        /// Circle constructor, where values are provided by params.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="position"></param>
        public Circle(float radius, Vector2 position)
        {
            this.radius = radius;
            this.position = position;
        }
    }
}
