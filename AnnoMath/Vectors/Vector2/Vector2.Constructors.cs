/// <summary>
/// AnnoMath library namespace with Vectors
/// </summary>
namespace AnnoMath.Vectors
{
    /// <summary>
    /// 2D Vector 
    /// </summary>
    public partial class Vector2
    {
        /// <summary>
        /// Default Vector2 constructor, where both values: x and y are set zero.
        /// </summary>
        public Vector2()
        {
            this.x = 0;
            this.y = 0;
        }

        /// <summary>
        /// Vector2 constructor, where values are provided by params.
        /// </summary>
        /// <param name="x">X value of Vector2</param>
        /// <param name="y">Y value of Vector2</param>
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
