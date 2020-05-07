using System;

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
        private void SortEdges()
        {
            float[] edges = new float[] { this.A, this.B, this.C };
            Array.Sort(edges);
        }

        private void Validate()
        {
            // Check if triangle exists
            if(this.A + this.B < this.C || this.A + this.C < this.B || this.B + this.C < this.A)
            {
                throw new ArgumentOutOfRangeException("Triangle - this triangle doesn't exist");
            }

            SortEdges();

            // Setting TriangleEdgeType
            if(this.A == this.B && this.B == this.C)
            {
                this.triangleEdgeType = TriangleEdgeType.EquilateralTriangle;
            }
            else if(this.A == this.B || this.A == this.C || this.B == this.C)
            {
                this.triangleEdgeType = TriangleEdgeType.IsoscelesTriangle;
            }
            else
            {
                this.triangleEdgeType = TriangleEdgeType.PolygonalTriangle;
            }

            // Setting TriangleAngleType
            float squaredAB = this.A * this.A + this.B * this.B;
            float squaredC = this.C * this.C;

            if(squaredAB == squaredC)
            {
                this.triangleAngleType = TriangleAngleType.RightAngledTriangle;
            }
            else if(squaredAB > squaredC)
            {
                this.triangleAngleType = TriangleAngleType.AcuteAngledTriangle;
            }
            else
            {
                this.triangleAngleType = TriangleAngleType.ObtuseAngledTriangle;
            }
        }

        /// <summary>
        /// Calculate Triangle field
        /// </summary>
        /// <returns>Triangle field</returns>
        public float Field()
        {
            return (float)Math.Sqrt((this.A + this.B + this.C) * (-this.A + this.B + this.C) * (this.A - this.B + this.C) * (this.A + this.B - this.C)) / 4f;
        }

        /// <summary>
        /// Calculate Triangle circumference
        /// </summary>
        /// <returns>Triangle circumference</returns>
        public float Circumference()
        {
            return this.A + this.B + this.C;
        }

        /// <summary>
        /// Calculate angle between two edges of Triangle
        /// </summary>
        /// <param name="firstEdge"></param>
        /// <param name="secondEdge"></param>
        /// <returns>Calculated angle in radians</returns>
        public float Angle(TriangleEdgeSize firstEdge, TriangleEdgeSize secondEdge)
        {
            int index = (int)firstEdge + (int)secondEdge;

            float squeredA = this.A * this.A;
            float squeredB = this.B * this.B;
            float squeredC = this.C * this.C;

            switch(index)
            {
                case 1:
                    return (float)Math.Acos((squeredA + squeredB - squeredC) / (2f * this.A * this.B));
                case 2:
                    return (float)Math.Acos((squeredA + squeredC - squeredB) / (2f * this.A * this.C)); 
                case 3:
                    return (float)Math.Acos((squeredB + squeredC - squeredA) / (2f * this.B * this.C));
            }

            throw new InvalidOperationException("Triangle - Error 000001x");
        }
    }
}
