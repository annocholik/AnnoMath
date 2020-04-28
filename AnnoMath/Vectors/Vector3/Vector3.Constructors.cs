/// <summary>
/// AnnoMath library namespace with Vectors
/// </summary>
namespace AnnoMath.Vectors
{
    /// <summary>
    /// 3D Vector 
    /// </summary>
    public partial class Vector3
    {
        /// <summary>
        /// Default Vector3 constructor, where both values: x and y are set zero.
        /// </summary>
        public Vector3()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        /// <summary>
        /// Vector3 constructor, where values are provided by params.
        /// </summary>
        /// <param name="x">X value of Vector2</param>
        /// <param name="y">Y value of Vector2</param>
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Vector3 constructor, which convert Vector2 to Vector3 and 'z' value is set zero.
        /// </summary>
        /// <param name="vec"></param>
        public Vector3(Vector2 vec)
        {
            this.x = vec.x;
            this.y = vec.y;
            this.z = 0;
        }
    }
}
