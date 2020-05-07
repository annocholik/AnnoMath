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
        /// Default constructor, where edge is set one and position is set as default Vector2.
        /// </summary>
        public Squere()
        {
            this.edge = 1f;
            this.position = new Vector2();
        }

        /// <summary>
        /// Squere constructor, where values are provided by params.
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="position"></param>
        public Squere(float edge, Vector2 position)
        {
            this.edge = edge;
            this.position = position;
        }
    }
}
