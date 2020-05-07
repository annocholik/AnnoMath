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
        /// Default constructor, where all edges is set one and position is set as default Vector2.
        /// </summary>
        public Triangle()
        {
            this._edges = new float[] { 1f, 1f, 1f };
            this.position = new Vector2();
            Validate();
        }

        /// <summary>
        /// Squere constructor, where values are provided by params.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="position"></param>
        public Triangle(float A, float B, float C, Vector2 position)
        {
            this._edges = new float[] { A, B, C };
            this.position = position;
            Validate();
        }
    }
}
